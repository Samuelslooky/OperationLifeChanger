using OperationLifeChanger.Models.Fødevarer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models
{
    public class DataBaseConnection
    {
        private static string ConnectionString = "Data Source = (LocalDB)/MSSQLLocalDB;AttachDbFilename=E:/Projects/OperationLifeChanger/OperationLifeChanger/App_Data/Database.mdf;Integrated Security = True";

        public bool OpretFødevare(string navn, string beskrivelse, Proteiner protein, Fedt fedt, Kulhydrater kulhydrat, Vitaminer vitaminer, Mineraler mineraler, AndetFødevareInfo andet)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConnectionString;
                conn.Open();

                SqlCommand command = new SqlCommand(@"
                    INSERT INTO Fødevarer (Navn, Beskrivelse)
                    VALUES (@Navn, @Beskrivelse);

                    INSERT INTO FødevarerKulhydrater (FødevareID, SamletKulhydrat, Sukkerarter, Fibre) 
                    VALUES (SCOPE_IDENTITY(), @SamletKulhydrat, @Sukkerarter, @Fibre);

                    INSERT INTO FødevarerProteiner (FødevarerID, SamletProteiner)
                    VALUES (SCOPE_IDENTITY(), @SamletProteiner);
    
                    INSERT INTO FødevarerFedt (FødevarerID, SamletFedt, MættetFedt, FlerumættetFedtsyrer, 
                        EnkeltumættetFedtsyrer, Omega3, Omega6)
                    VALUES (SCOPE_IDENTITY(), @SamletFedt, @MættetFedt, @FlerumættetFedtsyrer, 
                        @EnkeltumættetFedtsyrer, @Omega3, @Omega6);
                    
                    INSERT INTO FødevarerMineraler (FødevarerID, Calcium, Jod, Jern, Magnesium, Fosfor, 
                        Kobber, Mangan, Krom, Molybdæn, Zink, Kalium)
                    VALUES (SCOPE_IDENITITY(), @Calcium, @Jod, @Jern, @Magnesium, @Fosfor, @Kobber, 
                        @Mangan, @Krom, @Molybdæn, @Zink, @Kalium);

                    INSERT INTO FødevarerVitaminer (FødevarerID, A, B1, B2, B3, B5, B6, B7, B9, B12, C, D, E, K)
                    VALUES (SCOPE_IDENTITY(), @A, @B1, @B2, @B3, @B5, @B6, @B7, @B9, @B12, @C, @D, @E, @K);
                ");

                command.Parameters.Add(new SqlParameter("@Navn", navn));
                command.Parameters.Add(new SqlParameter("@Beskrivelse", beskrivelse));
                command.Parameters.Add(new SqlParameter("@SamletKulhydrat", kulhydrat.kulhydratListe[0]));
                command.Parameters.Add(new SqlParameter("@Sukkerarter", navn));
                command.Parameters.Add(new SqlParameter("@Fibre", navn));
                command.Parameters.Add(new SqlParameter("@SamletProteiner", navn));
                command.Parameters.Add(new SqlParameter("@SamletFedt", navn));
                command.Parameters.Add(new SqlParameter("@MættetFedt", navn));
                command.Parameters.Add(new SqlParameter("@FlerumættetFedtsyrer", navn));
                command.Parameters.Add(new SqlParameter("@EnkeltumættetFedtsyrer", navn));
                command.Parameters.Add(new SqlParameter("@Omega3", navn));
                command.Parameters.Add(new SqlParameter("@Omega6", navn));
                command.Parameters.Add(new SqlParameter("@Calcium", navn));
                command.Parameters.Add(new SqlParameter("@Jod", navn));
                command.Parameters.Add(new SqlParameter("@Jern", navn));
                command.Parameters.Add(new SqlParameter("@Magnesium", navn));
                command.Parameters.Add(new SqlParameter("@Fosfor", navn));
                command.Parameters.Add(new SqlParameter("@Kobber", navn));
                command.Parameters.Add(new SqlParameter("@Mangan", navn));
                command.Parameters.Add(new SqlParameter("@Krom", navn));
                command.Parameters.Add(new SqlParameter("@Molybdæn", navn));
                command.Parameters.Add(new SqlParameter("@Zink", navn));
                command.Parameters.Add(new SqlParameter("@Kalium", navn));
                command.Parameters.Add(new SqlParameter("@A", navn));
                command.Parameters.Add(new SqlParameter("@B1", navn));
                command.Parameters.Add(new SqlParameter("@B2", navn));
                command.Parameters.Add(new SqlParameter("@B3", navn));
                command.Parameters.Add(new SqlParameter("@B5", navn));
                command.Parameters.Add(new SqlParameter("@B6", navn));
                command.Parameters.Add(new SqlParameter("@B7", navn));
                command.Parameters.Add(new SqlParameter("@B9", navn));
                command.Parameters.Add(new SqlParameter("@B12", navn));
                command.Parameters.Add(new SqlParameter("@C", navn));
                command.Parameters.Add(new SqlParameter("@D", navn));
                command.Parameters.Add(new SqlParameter("@E", navn));
                command.Parameters.Add(new SqlParameter("@K", navn));

                SqlDataReader reader = command.ExecuteReader();

                conn.Close();


                return false;
            }
        }
    }
}