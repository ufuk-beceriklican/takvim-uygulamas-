                                                                                                                                                    using System;
                                                                                                                                                    using System.Data;
                                                                                                                                                    using System.Data.SqlClient;
                                                                                                                                                    using System.Windows.Forms;

                                                                                                                                                    namespace YazılımYapımı
                                                                                                                                                    {
                                                                                                                                                        public partial class Form2 : Form
                                                                                                                                                        {
                                                                                                                                                            // Bağlantı dizesi
                                                                                                                                                            static string connectionString = "Data Source=DESKTOP-K55SVSC\\SQLEXPRESS;Initial Catalog=VeriTabanı;Integrated Security=True";

                                                                                                                                                            public Form2()
                                                                                                                                                            {
                                                                                                                                                                InitializeComponent();
                                                                                                                                                            }

                                                                                                                                                            private void Form2_Load(object sender, EventArgs e)
                                                                                                                                                            {
                                                                                                                                                                // Textbox'a tarihi yazma
                                                                                                                                                                textBox1.Text = UserControlDays.static_day + "/" + Form3.static_month + "/" + Form3.static_year;
                                                                                                                                                            }

                                                                                                                                                            private void button1_Click(object sender, EventArgs e)
                                                                                                                                                            {
                                                                                                                                                                try
                                                                                                                                                                {
                                                                                                                                                                    using (SqlConnection conn = new SqlConnection(connectionString))
                                                                                                                                                                    {
                                                                                                                                                                        conn.Open();

                                                                                                                                                                        string sql = "INSERT INTO Table_2(Tarih, Açıklama) VALUES (@Tarih, @Açıklama)";
                                                                                                                                                                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                                                                                                                                                                        {
                                                                                                                                                                            cmd.Parameters.AddWithValue("@Tarih", textBox1.Text);
                                                                                                                                                                            cmd.Parameters.AddWithValue("@Açıklama", textBox2.Text);

                                                                                                                                                                            cmd.ExecuteNonQuery();
                                                                                                                                                                        }

                                                                                                                                                                        MessageBox.Show("Kaydedildi");
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                                catch (Exception ex)
                                                                                                                                                                {
                                                                                                                                                                    MessageBox.Show("Hata Meydana Geldi: " + ex.Message);
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }