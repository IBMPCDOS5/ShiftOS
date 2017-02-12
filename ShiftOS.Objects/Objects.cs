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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftOS.Objects
{
    public class MUDMemo
    {
        public string UserFrom { get; set; }
        public string UserTo { get; set; }
        public MemoType Type { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
    }

    public enum MemoType
    {
        Regular,
        Job,
        LegionInvite,
    }


    public class PongHighscore
    {
        public string UserName { get; set; }
        public int HighestLevel { get; set; }
        public int HighestCodepoints { get; set; }
    }

    public class GUIDRequest
    {
        public string name { get; set; }
        public string guid { get; set; }
    }

    public class OnlineUser
    {
        public string Guid { get; set; }
        public string Username { get; set; }
        public string OnlineChat { get; set; }
    }

    public class Channel
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Topic { get; set; }
        public int MaxUsers { get; set; } //0 for unlimited users (or the MUD maximum)
        public List<Save> Users = new List<Save>();
        public bool IsDiscordProxy { get; set; }
        public string DiscordBotToken { get; set; }
        public string DiscordChannelID { get; set; }
    }

    public class ChatMessage
    {
        public ChatMessage(string uname, string sys, string message, string chan)
        {
            Username = uname;
            SystemName = sys;
            Message = message;
            Channel = chan;
        }

        public string Username { get; private set; }
        public string SystemName { get; private set; }
        public string Channel { get; private set; }
        public string Message { get; private set; } 
    }

    [Serializable]
    public class ServerMessage
    {
        public string Name { get; set; }
        public string Contents { get; set; }
        public string GUID { get; set; }
    }
}
