/*
 * Created by Ranorex
 * User: DWood
 * Date: 4/10/2018
 * Time: 2:48 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace engine.Helpers
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class SQLUtility
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        /// <summary>
        /// DataTable used to store results of SQL query
        /// </summary>
        public static DataTable dt = new DataTable();
 
        /// <summary>
        /// This will query the database and store the results of the completed assessment into a datatable
        /// </summary>
        /// <param name="dbserver">The server you want to connect to</param>
        /// <param name="database">The database name to query</param>
        /// <param name="username">Username credential for the server</param>
        /// <param name="password">Password credential for the server</param>
        /// <param name="authentication">The authenticaiton method for connecting to the database. This is only needed for connecting using domain username and password</param>
        [UserCodeMethod]
        public static void GetAssessmentOutcomes(string dbserver, string database, string username, string password, string authentication)
        {
        	dt.Clear();
		
        	//Build sql query and connection string
			string query = "SELECT " +
						"IQNumber, DateOfBirth, BirthYear, Age, SessionID, SessionDate, SessionAttempt, SessionDuration, SessionCompletionPass, SessionPerformancePass, SessionIntegrityPass, " +
						"Test, TestCode, TestVersion, TestPhase, Round, TestAttempt, TestCompletionPass, TestPerformancePass, TestIntegrityPass, " +
				       "TestDuration, PrimaryOutcome, ReactionTime, RawReactionTime, RTVariability, RawRTVariability, Accuracy, RawAccuracy, TotalCorrect, TotalCorrectExclPant, TotalErrors, " +
					 "LegalErrors, RuleBreakErrors, TotalAnticipatory, TotalPost, TotalMaxOut, TotalCorrectFoils, TotalResponses, TotalTrials, MovesPerSecond, ReturnToHead, PerseverativeErrors, " +
				    "WithinSearchErrors, GMLTIndex, StandardScoreZ, StandardScoreT, ChangeScore, PsyAttStdScr, PsyAttChange, LearnWMStdScr, LearnWMChange, AltLearnWMStdScr, AltStandardScoreZ, AltStandardScoreT, AlternateOutcome " +
				"FROM [Reports].[vwExtractStandardAssessmentDetail] WHERE TestIdentifier = '" + WebService.TestIdentifier + "' ORDER BY TestId ASC";
			string sqlConnString = string.Format("Server={0};Database={1};User Id={2};Password={3};Authentication={4};Connection Timeout={5};", dbserver, database, username, password, authentication, "30");

			//Send the query to the database and store the results in a DataTable
			using (var da = new SqlDataAdapter(query, sqlConnString))
	        {
				da.Fill(dt);
			}
								
		}
    }
}
