using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using FireSharp.Response;

namespace CashInBox.Class_Access_DataBase
{
    public class FirebaseContext
    {
        private const string databaseUrl = "https://member-database-af2bd.firebaseio.com/";
        private const string databaseSecret = "eCxkHw7CaGFPqeezby62Fzg5ei8YQhnmQdzcUb2r";

        private static FirebaseClient instance;
        public static FirebaseClient Instance
        {
            get
            {
                if (instance == null) new FirebaseContext();

                return instance;
            }
        }

        private FirebaseContext()
        {
            instance = new FirebaseClient(
            databaseUrl,
            new FirebaseOptions
            {
                AuthTokenAsyncFactory = () => Task.FromResult(databaseSecret)

            });
        }
    }
}
