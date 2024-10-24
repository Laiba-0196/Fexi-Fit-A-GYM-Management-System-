using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fexi_Fit_Project
{
    using System;
    using System.IO;
        class FeedbackSystem
        {
            private const string FeedbackFilePath = "feedback.txt";

            public static void SubmitFeedback(string name, string email, string message)
            {
                // Create a formatted feedback entry
                string feedbackEntry = $"{DateTime.Now}, {name}, {email}, {message}";

                // Append the feedback entry to the feedback file
                File.AppendAllText(FeedbackFilePath, feedbackEntry + Environment.NewLine);
            }

            public static string[] GetFeedbackEntries()
            {
                // Read and return all feedback entries from the feedback file
                if (File.Exists(FeedbackFilePath))
                {
                    return File.ReadAllLines(FeedbackFilePath);
                }
                else
                {
                    return new string[0]; // Return an empty array if the feedback file doesn't exist
                }
            }
        }
    

}
