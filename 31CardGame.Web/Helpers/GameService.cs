﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using _31CardGame.Shared.Models;

namespace _31CardGame.Web.Helpers
{
    public class GameService : IGameService
    {
        private readonly string AppDataPath;

        public GameService()
        {
            AppDataPath = Path.Combine(
                Environment.GetEnvironmentVariable(RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "LocalAppData" : "HOME"), "31CardGame");
            Directory.CreateDirectory(AppDataPath);

        }

        private string GetFilePath(int GameId)
        {
            return Path.Combine(AppDataPath, GameId.ToString() + ".json");
        }

        public int CleanupOldGames()
        {
            int cnt = 0;
            foreach (var f in Directory.GetFiles(AppDataPath, "*.json"))
            {
                FileInfo fi = new FileInfo(f);
                if (fi.LastAccessTime.AddDays(1) < DateTime.Now)
                {
                    File.Delete(f);
                    cnt++;
                }
            }
            return cnt;
        }

        /// <summary>
        /// Save game
        /// </summary>
        /// <param name="g"></param>
        public void SaveGame(Game g)
        {
            string filename = GetFilePath(g.GameId);
            File.WriteAllText(filename, g.SerializeGame());
        }


        public Game LoadGame(int id)
        {
            return Game.DeserializeGame(File.ReadAllText(GetFilePath(id)));
        }

        public void DeleteGame(int id)
        {
            File.Delete(GetFilePath(id));
        }

        public bool GameExist(int id)
        {
            return File.Exists(GetFilePath(id));
        }
    }
}