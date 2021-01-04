using System;
using System.Collections.Generic;

namespace data{
    public static class GlobalConfig{
        public static Dictionary<string, string> EnviromentVariables = (Dictionary<string, string>)Environment.GetEnvironmentVariables();

        public static string GetPostgresConnectionString(){
            string host = EnviromentVariables["DB_SERVICE_NAME"] ?? "localhost";
            string database = EnviromentVariables["POSTGRES_DB"] ?? "dev_db";
            string username = EnviromentVariables["POSTGRES_USER"] ?? "dev";
            string password = EnviromentVariables["POSTGRES_PASSWORD"] ?? "development";

            return $"Host={host};Database={database};Username={username};Password={password}";
        }
    }
}
