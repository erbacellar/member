using Firebase.Database;
using System.Threading.Tasks;

namespace Member.Dao.Context
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
