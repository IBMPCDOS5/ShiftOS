﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShiftOS.Objects;

namespace ShiftOS.Engine
{
    public static class VirusManager
    {
        public static List<IVirus> ActiveInfections = new List<IVirus>();

        public static void Init()
        {
            Desktop.InvokeOnWorkerThread(() =>
            {
                ActiveInfections = new List<IVirus>();
                if (SaveSystem.CurrentSave.ViralInfections == null)
                    SaveSystem.CurrentSave.ViralInfections = new List<ViralInfection>();
                foreach (var virusdata in SaveSystem.CurrentSave.ViralInfections)
                {
                    var virus = CreateVirus(virusdata.ID, virusdata.ThreatLevel);
                    var existing = ActiveInfections.FirstOrDefault(x => x.GetType() == virus.GetType());
                    if (existing != null)
                    {
                        var eIndex = ActiveInfections.IndexOf(existing);
                        ActiveInfections[eIndex] = virus;
                        existing.Disinfect();
                    }
                    else
                    {
                        ActiveInfections.Add(virus);
                    }
                }
            });
        }

        public static void Infect(string id, int threatlevel)
        {
            if (threatlevel < 1)
                throw new Exception("Threat level can't be below 1.");
            if (threatlevel > 4)
                throw new Exception("Threat level can't be above 4.");

            var infection = SaveSystem.CurrentSave.ViralInfections.FirstOrDefault(x => x.ID == id);
            if (infection != null)
            {
                if(infection.ThreatLevel < threatlevel)
                {
                    infection.ThreatLevel = threatlevel;
                }
            }
            else
            {
                SaveSystem.CurrentSave.ViralInfections.Add(new ViralInfection
                {
                    ID = id,
                    ThreatLevel = threatlevel
                });
            }
            var virus = CreateVirus(id, threatlevel);
            var existing = ActiveInfections.FirstOrDefault(x => x.GetType() == virus.GetType());
            if(existing != null)
            {
                var eIndex = ActiveInfections.IndexOf(existing);
                ActiveInfections[eIndex] = virus;
                existing.Disinfect();
            }
            else
            {
                ActiveInfections.Add(virus);
            }
        }

        internal static IVirus CreateVirus(string id, int threatlevel)
        {
            if (threatlevel < 1)
                throw new Exception("Threat level can't be below 1.");
            if (threatlevel > 4)
                throw new Exception("Threat level can't be above 4.");

            foreach(var type in ReflectMan.Types.Where(x => x.GetInterfaces().Contains(typeof(IVirus)) && Shiftorium.UpgradeAttributesUnlocked(x)))
            {
                var attrib = type.GetCustomAttributes(false).FirstOrDefault(x => x is VirusAttribute) as VirusAttribute;
                if(attrib != null)
                {
                    if(attrib.ID == id)
                    {
                        IVirus virus = (IVirus)Activator.CreateInstance(type);
                        virus.Infect(threatlevel);
                        return virus;
                    }
                }
            }

            throw new Exception("Cannot create virus.");
        }
    }
}
