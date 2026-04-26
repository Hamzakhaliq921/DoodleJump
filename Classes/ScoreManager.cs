using DoodleJump.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoodleJump
{
public static class ScoreManager
        {
            public static string HashScore(int score)
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    // ComputeHash - returns byte array
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(score.ToString()));

                    // Convert byte array to a string
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }

            public static void UpdateScore(int points)
            {
                PlatformController.score += points;
                string hashedScore = HashScore(PlatformController.score);
                // Store or display the hashed score as needed
                // For example, you can log it or display it in the UI
                System.Diagnostics.Debug.WriteLine($"Hashed Score: {hashedScore}");
            }
        }
    }
