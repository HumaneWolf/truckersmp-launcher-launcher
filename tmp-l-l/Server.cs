using System;

namespace tmp_l_l
{
    class Server : IComparable<Server>
    {
        private static double waitTimeModifier = 0.7;

        private string game;
        private string name;
        private bool online;
        private int players;
        private int maxPlayers;
        private int queue;
        private bool speedLimiter;

        public Server(string game, string name, bool online, int players, int maxPlayers, int queue, bool speedLimiter)
        {
            this.game = game;
            this.name = name;
            this.online = online;
            this.players = players;
            this.maxPlayers = maxPlayers;
            this.queue = queue;
            this.speedLimiter = speedLimiter;
        }

        public int CompareTo(Server s)
        {
            return colName.CompareTo(s.colName);
        }

        public string colName
        {
            get
            {
                return game + ": " + name;
            }
        }

        public string colPlayers
        {
            get
            {
                if (online == true)
                {
                    return players + " / " + maxPlayers;
                }
                else
                {
                    return "Server Offline";
                }
            }
        }

        public string colQueue
        {
            get
            {
                if (queue == 0)
                {
                    return "no queue";
                }
                else
                {
                    int seconds = (int)Math.Floor(queue * waitTimeModifier);
                    int minutes;
                    int hours;

                    minutes = (int)Math.Floor((double)(seconds / 60));
                    seconds = seconds - (minutes * 60);

                    hours = (int)Math.Floor((double)(minutes / 60));
                    minutes = minutes - (hours * 60);

                    return queue + " players\n(waiting: " + hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00") + ")";
                }
            }
        }
    }
}
