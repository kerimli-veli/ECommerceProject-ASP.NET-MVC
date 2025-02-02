using Newtonsoft.Json;

namespace ECommerce.WebUI.Extensions
{
    public static class SessionExtensionMethods
    {
        public static void SetObject (this ISession session, string key, object value)
        {
            string objectstring = JsonConvert.SerializeObject (value);
            session.SetString (key, objectstring);
        }

        public static T GetObject<T>(this ISession session, string key) where T : class
        { 
            string objectString = session.GetString(key);
            if (string.IsNullOrEmpty(objectString))
                return null;
            T result = JsonConvert.DeserializeObject<T> (objectString);
            return result;

        } 


    }
}
