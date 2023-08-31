using Dapper;
using MBLDTracker.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MBLDTracker.DataAccess
{
    public class SQLiteConnector
    {
        private static string db = "MBLDDB";
        private static string connectionString = ConfigurationManager.ConnectionStrings[db].ConnectionString;
        public static void CreateAttempt(AttemptModel attempt)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Execute($@"INSERT INTO Attempts(Attempted, DateAttempted, Completed)
                             VALUES(@Attempted, @DateAttempted, 0);", attempt);
                attempt.Id = (int)(Int64)connection.ExecuteScalar("SELECT MAX(Id) FROM Attempts;");
                
                foreach (ScrambleModel scramble in attempt.Scrambles)
                {
                  connection.Execute(@$"INSERT INTO Scrambles(AttemptId, ColorString, Scramble)
                  VALUES({attempt.Id}, @ColorString, @Scramble);", scramble);
                }
                
            }
        }
        public static List<AttemptModel> LoadCompletedAttempts()
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                return connection.Query<AttemptModel>("SELECT * FROM Attempts WHERE Completed = 1").ToList();

            }
        }
        public static List<AttemptModel> LoadUncompletedAttempts()
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                return connection.Query<AttemptModel>("SELECT * FROM Attempts WHERE Completed = 0").ToList();
            }
        }
        public static void DeleteAttempt(AttemptModel attempt)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Execute("DELETE FROM Scrambles WHERE AttemptId = @Id", attempt);
                connection.Execute("DELETE FROM Attempts WHERE Id = @Id;", attempt);
            }
        }
        public static List<ScrambleModel> LoadScramblesById(int Id)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                {
                    return connection.Query<ScrambleModel>($"SELECT * FROM Scrambles WHERE AttemptId = {Id};").ToList();
                }
            }
        }
        public static void SaveResults(AttemptModel attempt)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Execute($@"UPDATE Attempts
                SET Solved = @Solved, SolvedAtHour = @SolvedAtHour, 
                MemoTime = @MemoTime, TotalTime = @TotalTime,
                Notes = @Notes, Completed = {1}
                WHERE Id = @Id;", attempt);
            }
        }
        public static void UpdateAttempt(AttemptModel attempt)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Execute($@"UPDATE Attempts
                SET
                Solved = @Solved,
                SolvedAtHour = @SolvedAtHour,
                MemoTime = @MemoTime,
                TotalTime = @TotalTime,
                Notes = @Notes
                WHERE Id = @Id", attempt);
            }
        }

    }
}
