using Minesweeper.MinesweeperForm.MenuStates.ScoresMenu.Scores;
using System;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Minesweeper.MinesweeperForm.MenuStates.ScoresMenu.ScoreDatabase
{
    internal static class ScoreDatabaseTools
    {

        public static void addScoreToDatabase(string name, int boardSizeID, TimeSpan timeTaken)
        {
            Score scoreToAdd = new Score(name, boardSizeID, timeTaken);

            SqlConnection sqlConnection = CreateDatabaseConnection();
            SqlCommand insertCommand = new SqlCommand("INSERT INTO Score (Name, Size, Time) VALUES (@Name, @Size, @Time)");
            insertCommand.Connection = sqlConnection;

            insertCommand.Parameters.AddWithValue("@Name", scoreToAdd.Name);
            insertCommand.Parameters.AddWithValue("@Size", scoreToAdd.BoardSizeID);
            insertCommand.Parameters.AddWithValue("@Time", scoreToAdd.TimeTaken);
            insertCommand.ExecuteNonQuery();

            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        public static BindingList<Score> GetScoresFromDatabase()
        {
            BindingList<Score> retrievedScores = new BindingList<Score>();

            SqlConnection dbConnection = CreateDatabaseConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Score", dbConnection);
            SqlDataReader reader = selectCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Score scoreFromDatabase = new Score(
                        reader["Name"].ToString(),
                        Convert.ToInt16(reader["Size"]),
                        TimeSpan.Parse(reader["Time"].ToString())
                    );

                    retrievedScores.Add(scoreFromDatabase);
                }

                reader.Close();
                dbConnection.Close();
                dbConnection.Dispose();
            }
            return retrievedScores;
        }

        private static SqlConnection CreateDatabaseConnection()
        {
            string mdfPath = "E:\\School\\NET_Development\\Homework\\Minesweeper\\Minesweeper\\MinesweeperForm\\MenuStates\\ScoresMenu\\ScoreDatabase\\ScoreDatabase.mdf";

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=true;AttachDBFilename=" + mdfPath;

            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            return dbConnection;
        }

        public static void clearDatabase()
        {
            SqlConnection dbConnection = CreateDatabaseConnection();

            SqlCommand deleteAllCommand = new SqlCommand("DELETE FROM Score");
            deleteAllCommand.Connection = dbConnection;
            deleteAllCommand.ExecuteNonQuery();

            //reseed the database
            SqlCommand reseedCommand = new SqlCommand("DBCC CHECKIDENT ('Score', RESEED, 0);");
            reseedCommand.Connection = dbConnection;
            reseedCommand.ExecuteNonQuery();

            dbConnection.Close();
            dbConnection.Dispose();
        }
    }
}
