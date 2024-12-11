using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Helper;

namespace GameQuizWindowsApp
{
    public partial class Ranking : Form
    {
        private AuthenticationHelper.User currentUser;
        private string connectionString = "Server=localhost;Database=dataGameQuiz;Uid=root;Pwd=;";

        public Ranking(AuthenticationHelper.User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadLeaderboard();
            LoadCurrentUserRank();
        }

        private void LoadLeaderboard()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT u.username, s.score, s.time " +
                                   "FROM score s " +
                                   "JOIN user u ON s.user_id = u.id " +
                                   "ORDER BY s.score DESC, s.time ASC " +
                                   "LIMIT 5";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    var reader = cmd.ExecuteReader();

                    Label[] labels = { lblPlayer1, lblPlayer2, lblPlayer3, lblPlayer4, lblPlayer5 };
                    int index = 0;

                    while (reader.Read() && index < labels.Length)
                    {
                        string username = reader.GetString("username");
                        int score = reader.GetInt32("score");
                        double time = Math.Round(reader.GetDouble("time"), 3);

                        labels[index].Text = $"Top {index + 1}: {username} - Score: {score} - Time: {time:F3}";
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leaderboard: " + ex.Message);
            }
        }

        private void LoadCurrentUserRank()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string queryRank = "SELECT COUNT(*) + 1 AS rank " +
                                       "FROM score " +
                                       "WHERE (score > (SELECT score FROM score WHERE user_id = @user_id)) " +
                                       "OR (score = (SELECT score FROM score WHERE user_id = @user_id) " +
                                       "AND time < (SELECT time FROM score WHERE user_id = @user_id))";

                    MySqlCommand cmdRank = new MySqlCommand(queryRank, connection);
                    cmdRank.Parameters.AddWithValue("@user_id", currentUser.Id);

                    int userRank = Convert.ToInt32(cmdRank.ExecuteScalar());

                    string queryUserScore = "SELECT u.username, s.score, s.time " +
                                            "FROM score s " +
                                            "JOIN user u ON s.user_id = u.id " +
                                            "WHERE u.id = @user_id";

                    MySqlCommand cmdUserScore = new MySqlCommand(queryUserScore, connection);
                    cmdUserScore.Parameters.AddWithValue("@user_id", currentUser.Id);

                    using (var reader = cmdUserScore.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string username = reader.GetString("username");
                            int score = reader.GetInt32("score");
                            double time = Math.Round(reader.GetDouble("time"), 3);
                            lblCurrentUserRank.Text = $"You: {userRank} - {username} : Score: {score} - Time: {time:F3}";
                        }
                        else
                        {
                            lblCurrentUserRank.Text = "You have not played any games yet. Please play to see your rank..";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user rank: " + ex.Message);
            }
        }
    }
}
