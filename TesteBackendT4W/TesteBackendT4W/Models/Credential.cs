namespace TesteBackendT4W.Models
{

    /// <summary>
    /// Credentials used in the API request
    /// </summary>
    public class Credential
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Credential()
        {
            this.Username = "candidato_t4w";
            this.Password = "candit@!2019";
        }

    }
}