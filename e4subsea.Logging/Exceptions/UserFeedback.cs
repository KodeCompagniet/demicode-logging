using System;

namespace e4subsea.Logging.Exceptions
{
    public class UserFeedback
    {
        public UserFeedback(string username, string additionalInformation)
        {
            Username = username;
            AdditionalInformation = additionalInformation;
        }

        /// <summary>
        /// The name of the user.
        /// </summary>
        public string Username { get; private set; }

        /// <summary>
        /// Additional information provided by the user.
        /// </summary>
        public string AdditionalInformation { get; private set; }

        /// <summary>
        /// Return an empty user feedback.
        /// </summary>
        public static readonly UserFeedback Empty = new UserFeedback("", "");

        public override string ToString()
        {
            return String.Format("Username: {0}\nInfo:\n{1}", Username, AdditionalInformation);
        }
    }
}