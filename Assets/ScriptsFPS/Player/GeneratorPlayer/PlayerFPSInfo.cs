namespace GameFPS
{
    public class PlayerFPSInfo
    {
        private readonly string namePlayer;
        private readonly int actor;
    
        public string NamePlayer { get => namePlayer; }
        public int Actor { get => actor; }

        protected PlayerFPSInfo(string namePlayer, int actor)
        {
            this.namePlayer = namePlayer;
            this.actor = actor;
        }
    }

    public class PlayerFPSInfoBasic : PlayerFPSInfo
    {
        private readonly int kills, deaths;
    
        public int Kills { get => kills; }
        public int Deaths { get => deaths; }

        public PlayerFPSInfoBasic(string namePlayer, int actor, int kills, int deaths, int score) : base(namePlayer, actor)
        {
            this.kills = kills;
            this.deaths = deaths;
        }
    }

    public class PlayerFPSInfoZombie : PlayerFPSInfo
    {
        private readonly int survive, score;
    
        public int Survive { get => survive; }
        public int Score { get => score; }

        public PlayerFPSInfoZombie(string namePlayer, int actor, int survive, int score) : base(namePlayer, actor)
        {
            this.survive = survive;
            this.score = score;
        }
    }
}

