using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TweetSharp;

namespace Tweeder
{
    /// <summary>
    /// Appplication that searches for a number of tweets either by user or hashtag
    /// </summary>
    public partial class Tweeder : Form
    {
        //Global Variables
        TwitterService sTwitterService;
        string consumerKeyString = "CONSUMER_KEY"; 
        string consumerSecretString = "CONSUMER_SECRET_KEY";
        string tokenString = "TOKEN";
        string tokenSecret = "TOKEN_SECRET";

        public Tweeder()
        {
            InitializeComponent();
        }

        private void Tweeder_Load(object sender, EventArgs e)
        {            
            sTwitterService = new TwitterService(consumerKeyString, consumerSecretString);
            sTwitterService.AuthenticateWith(tokenString, tokenSecret);
        }

        /// <summary>
        /// Search tweets by user 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchByUserButton_Click(object sender, EventArgs e)
        {
            //Validate input fields are not empty
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text) && !string.IsNullOrWhiteSpace(numberTweetsTextBox.Text))
            {
                int numberTweetsInt;
                //Excption handling for parsing string into integer and retrieving tweets
                try
                {
                    numberTweetsInt = Int32.Parse(numberTweetsTextBox.Text);
                    if (numberTweetsInt > 0)//Verify number of tweet is greter than 0
                    {
                        tweetsListBox.Items.Clear(); //Clear listbox to make sure is empty
                        ListTweetsOnUserTimelineOptions tweetsList = new ListTweetsOnUserTimelineOptions();
                        tweetsList.ScreenName = searchTextBox.Text; //The Twitter Account/Handle name
                        //tweetsList.ExcludeReplies = true;
                        tweetsList.Count = numberTweetsInt; //How many tweets the user wants
                        var tweets = sTwitterService.ListTweetsOnUserTimeline(tweetsList);
                        if (tweets.Any()) // verify if any tweets exist
                        {
                            foreach (var tweet in tweets)
                            {
                                //Add tweet information to list box to be displayed
                                tweetsListBox.Items.Add(tweet.CreatedDate + ": " + tweet.Text);
                            }

                        }// end if
                        else
                        {
                            MessageBox.Show("No Tweets found for: " + searchTextBox.Text, "No tweets found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }//end else
                    }//end if
                    else
                    {
                        MessageBox.Show("Number of tweets need to be greter than 0 ", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }//end else
                    
                }//End of try block
                //Catch exception: user input invalid type on number of tweets field
                catch (FormatException formatException)
                {
                    MessageBox.Show("Invalid input in 'Number of tweets' field: \n" + numberTweetsTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //Catch execption: there were no tweets found for the Twitter Account/Handle name
                catch (ArgumentNullException noTweets)
                {
                    MessageBox.Show("No Tweets found for: " + searchTextBox.Text, "No tweets found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }//end if
            else
            {
                MessageBox.Show("Tweeter handle/hashtag and number of tweets field cannot be empty", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//end of else

        }//end of searchByUserButton_Click

        /// <summary>
        /// Search tweets by hashtag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchByHashtagButton_Click(object sender, EventArgs e)
        {
            //Validate input fields are not empty
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text) && !string.IsNullOrWhiteSpace(numberTweetsTextBox.Text))
            {
                int numberTweetsInt;
                //Excption handling for parsing string into integer and retrieving tweets
                try
                {
                    numberTweetsInt = Int32.Parse(numberTweetsTextBox.Text);
                    if (numberTweetsInt > 0)//Verify number of tweet is greter than 0
                    {
                        tweetsListBox.Items.Clear(); //Clear listbox to make sure is empty
                        SearchOptions so = new SearchOptions();
                        so.Q = searchTextBox.Text; //The Hashtag to look for
                        so.Count = numberTweetsInt; //How many tweets the user wants
                        var results = sTwitterService.Search(so);
                        if (results.Statuses.Any()) // verify if any tweets exist
                        {
                            foreach (var result in results.Statuses)
                            {
                                //Add tweet information to list box to be displayed
                                tweetsListBox.Items.Add(result.CreatedDate + " by " + result.User.ScreenName + ": " + result.Text);
                            }
                        }
                        //Show message when there were no tweets found with that hashtag
                        else
                        {
                            MessageBox.Show("No Tweets found for: " + searchTextBox.Text, "No tweets found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }//end if
                    else
                    {
                        MessageBox.Show("Number of tweets need to be greter than 0 ", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }//end else

                }//End of try block
                //Catch exception: user input invalid type on number of tweets field
                catch (FormatException formatException)
                {
                    MessageBox.Show("Invalid input in 'Number of tweets' field: \n" + numberTweetsTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }             

            }//End if
            else
            {
                MessageBox.Show("Tweeter handle/hashtag and number of tweets field cannot be empty", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//end of else
        }// end of searchByHashtagButton_Click 

        /// <summary>
        /// "About" menu option handler. Display a message box with information about application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This tweeter application lets you search for tweets by your favourite user or hashtag.", "Tweeder by Cindy Diaz", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//end of aboutToolStripMenuItem_Click

        /// <summary>
        /// "Exit" menu option handler, close tweeder application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//Close application
        }//edn of exitToolStripMenuItem_Click
    }
}
