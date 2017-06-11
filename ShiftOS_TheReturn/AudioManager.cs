/*
 * MIT License
 * 
 * Copyright (c) 2017 Michael VanOverbeek and ShiftOS devs
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

#define NOSOUND

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;

namespace ShiftOS.Engine
{
    public static class AudioManager
    {
        private static WaveOut _out = null;
        private static AudioFileReader _reader = null;
        private static IAudioProvider _provider = null;
        
        /// <summary>
        /// Stops the current sound if one is playing and disposes of the sound.
        /// </summary>
        public static void Stop()
        {
            Desktop.InvokeOnWorkerThread(() =>
            {
                _out?.Stop();
                _reader?.Dispose();
                _out?.Dispose();
            });
        }

        /// <summary>
        /// Initiates this engine module using an <see cref="IAudioProvider"/> as a backend for selecting background soundtrack as well as the volume level for the sound.
        /// </summary>
        /// <param name="_p">A background soundtrack and volume provider.</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="_p"/> is null.</exception> 
        public static void Init(IAudioProvider _p)
        {
            if (_p == null)
                throw new ArgumentNullException("_p");
            _provider = _p;
        }

        /// <summary>
        /// Sets the volume of the audio system.
        /// </summary>
        /// <param name="volume">The volume to use, from 0 to 1.</param>
        public static void SetVolume(float volume)
        {
            _provider.Volume = volume; //persist between songs
            _out.Volume = volume;
        }

        /// <summary>
        /// Plays a specified sound file.
        /// </summary>
        /// <param name="file">The file to play.</param>
        public static void Play(string file)
        {
            bool play = true;
            float volume = 1f;
            if (SaveSystem.CurrentSave != null)
            {
                play = (SaveSystem.CurrentSave.SoundEnabled);
                volume = (float)SaveSystem.CurrentSave.MusicVolume / 100f;
            }
            if (play)
            {
                try
                {
                    _reader = new AudioFileReader(file);
                    _out = new WaveOut();
                    _out.Init(_reader);
                    _out.Volume = volume;
                    _out.Play();
                    _out.PlaybackStopped += (o, a) => { PlayCompleted?.Invoke(); };
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Audio error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Writes the data in the specified <see cref="Stream"/> to a file, and plays it as a sound file. 
        /// </summary>
        /// <param name="str">The stream to read from.</param>
        public static void PlayStream(Stream str)
        {
            try
            {
                bool play = true;
                float volume = 1f;
                if (SaveSystem.CurrentSave != null)
                {
                    play = (SaveSystem.CurrentSave.SoundEnabled);
                    volume = (float)SaveSystem.CurrentSave.MusicVolume / 100f;
                }
                if (play)
                {
                    while(_out.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(10);
                    }
                    ShiftOS.Engine.AudioManager.Stop();
                    _out = new WaveOut();
                    var mp3 = new WaveFileReader(str);
                    _out.Init(mp3);
                    _out.Volume = volume;
                    _out.Play();
                    _out.PlaybackStopped += (o, a) => { PlayCompleted?.Invoke(); };
                }
            }
            catch { }
        }

        public static event Action PlayCompleted;
    }

    public interface IAudioProvider
    {
        /// <summary>
        /// Gets a byte[] array corresponding to an MP3 track given an index.
        /// </summary>
        /// <param name="index">A track index to use when finding the right track.</param>
        /// <returns>The MP3 byte[] array.</returns>
        byte[] GetTrack(int index);

        /// <summary>
        /// Gets the 1-based count of all available tracks.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Gets or sets the track player's volume.
        /// </summary>
        float Volume { get; set; }
    }
}
