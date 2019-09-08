using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameClass.Interfaces;
using GameClass.Players;

namespace GameClass
{
    public static class Game
    {
        private static List<Player> _Players;

        internal static List<int> _regularPlayerStats = new List<int>();
        internal static List<int> _notePlayerStats = new List<int>();
        internal static List<int> _uberPlayerStats = new List<int>();
        internal static List<int> _cheaterPlayerStats = new List<int>();
        internal static List<int> _uberCheaterPlayerStats = new List<int>();

        private static int _bucketWeight;
        private static int _result;
        private static int _tryCounter = 0;

        static Game()
        {
            _Players = new List<Player>();
        }

        public static void SetBucketWeight(int bucketWeight)
        {
            _bucketWeight = bucketWeight;
        }

        public static void AddPlayer(Player player)
        {
            _Players.Add(player);
        }

        public static Player Start()
        {
            Player player = null;
            bool flag = true;
            int tryCounter;

            while (flag)
            { 
                foreach (Player playerF in _Players)
                {
                    switch (playerF.Type)
                    {
                        case "Обычный":
                            IGame regularPlayer = new RegularPlayer(playerF.Name);
                            _result = regularPlayer.Play();
                            _regularPlayerStats.Add(_result);
                            player = playerF;
                            break;

                        case "Игрок-блокнот":
                            IGame notePlayer = new NotePlayer(playerF.Name);
                            _result = notePlayer.Play();
                            _notePlayerStats.Add(_result);
                            player = playerF;
                            break;

                        case "Убер-игрок":
                            IGame uberPlayer = new UberPlayer(playerF.Name);
                            _result = uberPlayer.Play();
                            _uberPlayerStats.Add(_result);
                            player = playerF;
                            break;

                        case "Читер":
                            IGame cheaterPlayer = new CheaterPlayer(playerF.Name);
                            _result = cheaterPlayer.Play();
                            _cheaterPlayerStats.Add(_result);
                            player = playerF;
                            break;

                        case "Убер-читер":
                            IGame uberCheaterPlayer = new UberCheaterPlayer(playerF.Name);
                            _result = uberCheaterPlayer.Play();
                            _uberCheaterPlayerStats.Add(_result);
                            player = playerF;
                            break;
                    }

                    _tryCounter++;

                    if (_tryCounter >= 100)
                    {
                        flag = false;
                        player = null;
                        break;
                    }

                    if (_result == _bucketWeight)
                    {
                        flag = false;
                        break;
                    }
                }
            }

            return player;
        }
    }
}
