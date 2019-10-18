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
		public static string ResetToken;
		//public static string N_TestIdentifier;
		
		/// <summary>
		/// This will query the database and store the results of the completed assessment into a datatable. This will use the TestIdentifer
		/// which was generated through the API when creating an assessment link
		/// </summary>
		/// <param name="dbserver">The server you want to connect to</param>
		/// <param name="database">The database name to query</param>
		/// <param name="username">Username credential for the server</param>
		/// <param name="password">Password credential for the server</param>
		/// <param name="authentication">The authenticaiton method for connecting to the database. This is only needed for connecting using domain username and password</param>
		[UserCodeMethod]
		public static void GetAssessmentOutcomes(string dbserver, string database, string username, string password, string authentication)
		{
			dt.Reset();
			
			string query = @"SELECT
	     Userdata.Part.IQNumber                                                                                                                 AS [IQNumber]
		,UserData.Person.DOB                                                                                                                    AS [DateOfBirth]
		,YEAR(UserData.Person.DOB)                                                                                                              AS [BirthYear]
		,Assessment.Assessment.Age                                                                                                              AS [Age]
		,Assessment.Assessment.Id                                                                                                               AS [SessionID]
		,CONVERT(VARCHAR(10), Assessment.Assessment.DateOfAssessment, 20)                                                                       AS [SessionDate]
		,CONVERT(VARCHAR(12), Assessment.Assessment.DateOfAssessment, 14)                                                                       AS [SessionTime]
		,(SELECT COUNT(1)
			FROM Assessment.AssessmentSessionAttempt asatt
			WHERE asatt.AssessmentSessionId = Assessment.AssessmentSession.Id
			AND asatt.id <= Assessment.AssessmentSessionAttempt.Id)                                                                             AS [SessionAttempt]
		,Assessment.Assessment.SessionDuration                                                                                                  AS [SessionDuration]
		,MAX(CASE WHEN Assessment.CompositeOutcome.[Name] = 'SessionCompletion'
			THEN CASE WHEN Assessment.AssessmentBatteryCompositeOutcome.[Value] = 1 THEN 'Yes'
			WHEN [AssessmentBatteryCompositeOutcome].[Value]=0 THEN 'No' ELSE null END END)                                                     AS [SessionCompletionPass]
		,MAX(CASE WHEN Assessment.CompositeOutcome.[Name] = 'SessionPerformance'
			THEN CASE WHEN Assessment.AssessmentBatteryCompositeOutcome.[Value] = 1 THEN 'Yes'
			WHEN [AssessmentBatteryCompositeOutcome].[Value]=0 THEN 'No' ELSE null END END)                                                     AS [SessionPerformancePass]
		,MAX(CASE WHEN Assessment.CompositeOutcome.[Name] = 'SessionIntegrity'
			THEN CASE WHEN Assessment.AssessmentBatteryCompositeOutcome.[Value] = 1 THEN 'Yes'
			WHEN Assessment.AssessmentBatteryCompositeOutcome.[Value]=0 THEN 'No' ELSE null END END)                                            AS [SessionIntegrityPass]
		,Assessment.Test.Id                                                                                                                     AS [TestId]
		,Assessment.Test.[Name]                                                                                                                 AS [Test]
		,Assessment.TestCode.[Name]                                                                                                             AS [TestCode]
		,Assessment.AssessmentTest.TaskVersion                                                                                                  AS [TestVersion]
		,MAX(CASE WHEN Assessment.Test.Descript like '%SAT%' THEN Assessment.AssessmentTestMetadata.[Value] END)								AS [TestSubset]
		,Assessment.TestCode.Phase                                                                                                              AS [TestPhase]
		,CASE WHEN Assessment.AssessmentTest.[Round] > 0
			THEN CAST(Assessment.AssessmentTest.[Round] as VARCHAR(10))
		    WHEN Assessment.AssessmentTest.[Round] = 0
			THEN 'Total' ELSE NULL END																										    AS [Round]
		,Assessment.AssessmentTest.Attempt                                                                                                      AS [TestAttempt]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'TestCompletion'
			THEN CASE WHEN Assessment.AssessmentTestOutcome.[Value] = 1 THEN 'Yes'
			WHEN Assessment.AssessmentTestOutcome.[Value]=0 THEN 'No' ELSE null END END)                                                        AS [TestCompletionPass]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'TestPerformance'
			THEN CASE WHEN Assessment.AssessmentTestOutcome.[Value] = 1 THEN 'Yes'
				WHEN Assessment.AssessmentTestOutcome.[Value]=0 THEN 'No' ELSE null END END)                                                    AS [TestPerformancePass]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'TestIntegrity'
			THEN CASE WHEN Assessment.AssessmentTestOutcome.[Value] = 1 THEN 'Yes'
			WHEN Assessment.AssessmentTestOutcome.[Value]=0 THEN 'No' ELSE null END END)														AS [TestIntegrityPass]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'TestDuration' THEN Assessment.AssessmentTestOutcome.[Value] END)                       AS [TestDuration]
		,MAX(CASE WHEN Assessment.Outcome.Description = [AssessmentOutcomePrimary].[Description] THEN Assessment.AssessmentTestOutcome.[Value] END)			AS [PrimaryOutcome]
		,MAX(CASE WHEN Assessment.Outcome.Description = [AssessmentOutcomeAlternate].[Description] THEN Assessment.AssessmentTestOutcome.[Value] END)		AS [AlternateOutcome]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'ReactionTime' THEN Assessment.AssessmentTestOutcome.[Value] END)                       AS [ReactionTime]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'RawReactionTime' THEN Assessment.AssessmentTestOutcome.[Value] END)                    AS [RawReactionTime]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'RTVariability' THEN Assessment.AssessmentTestOutcome.[Value] END)                      AS [RTVariability]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'RawRTVariability' THEN Assessment.AssessmentTestOutcome.[Value] END)                   AS [RawRTVariability]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'Accuracy' THEN Assessment.AssessmentTestOutcome.[Value] END)                           AS [Accuracy]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'RawAccuracy' THEN Assessment.AssessmentTestOutcome.[Value] END)                        AS [RawAccuracy]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'TotalCorrect' THEN Assessment.AssessmentTestOutcome.[Value] END)                       AS [TotalCorrect]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'TotalCorrectExclPant' THEN Assessment.AssessmentTestOutcome.[Value] END)               AS [TotalCorrectExclPant]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'TotalErrors' THEN Assessment.AssessmentTestOutcome.[Value] END)                        AS [TotalErrors]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'LegalErrors' THEN Assessment.AssessmentTestOutcome.[Value] END)                        AS [LegalErrors]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'RuleBreakErrors' THEN Assessment.AssessmentTestOutcome.[Value] END)                    AS [RuleBreakErrors]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'TotalAnticipatory' THEN Assessment.AssessmentTestOutcome.[Value] END)                  AS [TotalAnticipatory]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'TotalPost' THEN Assessment.AssessmentTestOutcome.[Value] END)                          AS [TotalPost]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'TotalMaxOut' THEN Assessment.AssessmentTestOutcome.[Value] END)                        AS [TotalMaxOut]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'TotalCorrectFoils' THEN Assessment.AssessmentTestOutcome.[Value] END)                  AS [TotalCorrectFoils]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'TotalResponses' THEN Assessment.AssessmentTestOutcome.[Value] END)                     AS [TotalResponses]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'TotalTrials' THEN Assessment.AssessmentTestOutcome.[Value] END)                        AS [TotalTrials]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'StandardScoreZ' THEN Assessment.AssessmentTestOutcome.[Value] END)                     AS [StandardScoreZ]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'StandardScoreT' THEN Assessment.AssessmentTestOutcome.[Value] END)                     AS [StandardScoreT]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'AltStandardScoreZ' THEN Assessment.AssessmentTestOutcome.[Value] END)                  AS [AltStandardScoreZ]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'AltStandardScoreT' THEN Assessment.AssessmentTestOutcome.[Value] END)                  AS [AltStandardScoreT]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'ChangeScore' THEN Assessment.AssessmentTestOutcome.[Value] END)                        AS [ChangeScore]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'MovesPerSecond' THEN Assessment.AssessmentTestOutcome.[Value] END)						AS [MovesPerSecond]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'ReturnToHead' THEN Assessment.AssessmentTestOutcome.Value END)							AS [ReturnToHead]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'PerseverativeErrors' THEN Assessment.AssessmentTestOutcome.Value END)					AS [PerseverativeErrors]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'WithinSearchErrors' THEN Assessment.AssessmentTestOutcome.Value END)					AS [WithinSearchErrors]
		,CASE
			WHEN Assessment.Test.Descript like '%GMLT%'
				THEN
				CAST(LEFT(Substring(Assessment.AssessmentTest.Details, Charindex(',', Assessment.AssessmentTest.Details)+1,
				LEN(Assessment.AssessmentTest.Details)),Charindex(',',Substring(Assessment.AssessmentTest.Details,
				Charindex(',', Assessment.AssessmentTest.Details)+1, LEN(Assessment.AssessmentTest.Details)))-1) AS INT)
				ELSE
				null
			END																																	AS [GMLTIndex]
		,MAX(CASE WHEN Assessment.Outcome.Description = 'SATScore' THEN Assessment.AssessmentTestOutcome.Value END)								AS [SATScore]
		,MAX(CASE WHEN Assessment.CompositeOutcome.[Name] = 'PsyAttStdScr'
			THEN Assessment.AssessmentBatteryCompositeOutcome.[Value] END)                                                                      AS [PsyAttStdScr]
		,MAX(CASE WHEN Assessment.CompositeOutcome.[Name] = 'PsyAttChange'
			THEN Assessment.AssessmentBatteryCompositeOutcome.[Value] END)                                                                      AS [PsyAttChange]
		,MAX(CASE WHEN Assessment.CompositeOutcome.[Name] = 'LearnWMStdScr'
			THEN Assessment.AssessmentBatteryCompositeOutcome.[Value] END)                                                                      AS [LearnWMStdScr]
		,MAX(CASE WHEN Assessment.CompositeOutcome.[Name] = 'LearnWMChange'
			THEN Assessment.AssessmentBatteryCompositeOutcome.[Value] END)                                                                      AS [LearnWMChange]
		,MAX(CASE WHEN Assessment.CompositeOutcome.[Name] = 'AltLearnWMStdScr'
			THEN Assessment.AssessmentBatteryCompositeOutcome.[Value] END)                                                                      AS [AltLearnWMStdScr]
		,UserData.PrWorkflowInstance.TestIdentifier                                                                                             AS [TestIdentifier]

		FROM Assessment.Assessee
		LEFT JOIN Assessment.AssessmentSession                                                                          ON Assessment.AssessmentSession.AssesseeId=Assessment.Assessee.Id
		LEFT JOIN Assessment.AssessmentSessionAttempt                                                                   ON Assessment.AssessmentSessionAttempt.AssessmentSessionId=Assessment.AssessmentSession.Id
		LEFT JOIN Assessment.Assessment                                                                                 ON Assessment.AssessmentSessionAttempt.Id=Assessment.Assessment.AssessmentSessionAttemptId
		LEFT JOIN Assessment.AssessmentTest                                                                             ON Assessment.AssessmentTest.AssessmentId=Assessment.Assessment.Id
		LEFT JOIN Assessment.TestCode                                                                                   ON Assessment.TestCode.Id=Assessment.AssessmentTest.TestCodeId
		LEFT JOIN Assessment.Test                                                                                       ON Assessment.TestCode.TestId=Assessment.Test.Id
		LEFT JOIN Assessment.AssessmentTestMetadata																		ON Assessment.AssessmentTest.Id=Assessment.AssessmentTestMetadata.AssessmentTestId
		LEFT JOIN Assessment.AssessmentTestOutcome                                                                      ON Assessment.AssessmentTestOutcome.AssessmentTestId=Assessment.AssessmentTest.Id
		LEFT JOIN Assessment.TestOutcome                                                                                ON Assessment.TestOutcome.Id=Assessment.AssessmentTestOutcome.OutcomeId
		LEFT JOIN Assessment.Outcome                                                                                    ON Assessment.Outcome.Id=Assessment.AssessmentTestOutcome.OutcomeId
		LEFT JOIN Assessment.AssessmentBatteryCompositeOutcome                                                          ON Assessment.AssessmentBatteryCompositeOutcome.AssessmentId=Assessment.Assessment.Id
		LEFT JOIN Assessment.BatteryCompositeOutcome                                                                    ON Assessment.BatteryCompositeOutcome.Id=Assessment.AssessmentBatteryCompositeOutcome.BatteryCompositeOutcomeId
		LEFT JOIN Assessment.CompositeOutcome                                                                           ON Assessment.CompositeOutcome.Id=Assessment.BatteryCompositeOutcome.CompositeOutcomeId
	    LEFT JOIN Assessment.Outcome                                    AS [AssessmentOutcomePrimary]                   ON [AssessmentOutcomePrimary].Id=Assessment.Test.PrimaryOutcomeId
		LEFT JOIN Assessment.Outcome                                    AS [AssessmentOutcomeAlternate]                 ON [AssessmentOutcomeAlternate].Id=Assessment.Test.AlternateOutcomeId
		LEFT JOIN Assessment.AssessmentSessionAttemptIssue              AS [AssessmentSessionAttemptIssue]              ON AssessmentSessionAttemptIssue.AssessmentSessionAttemptId=Assessment.AssessmentSessionAttempt.Id
		LEFT JOIN UserData.PrWorkflowInstance                                                                           ON UserData.PrWorkflowInstance.AssessmentSessionAttemptId=Assessment.AssessmentSessionAttempt.Id
		LEFT JOIN UserData.Person                                                                                       ON UserData.Person.Id=Assessment.Assessee.PersonId
		LEFT JOIN UserData.[User]                                                                                       ON UserData.[User].PersonId=[Userdata].Person.Id
		LEFT JOIN Userdata.[User]                                       AS [User2]                                      ON [Userdata].PRWorkflowInstance.UpdatedByUserId=[User2].id
		LEFT JOIN Userdata.Part                                                                                         ON [Userdata].Part.PersonId=UserData.Person.Id
		LEFT JOIN Study.Stud                                                                                            ON Userdata.Part.StudId=Study.Stud.Id
		LEFT JOIN Reference.Gender                                                                                      ON Reference.Gender.Id=UserData.Person.GenderId
		LEFT JOIN Reference.Locality                                                                                    ON [Userdata].Person.localityId=[Reference].Locality.Id
		LEFT JOIN [Study].[VisitSession]                                                                                ON [Study].[VisitSession].Id=[Userdata].PRWorkflowInstance.VisitSessionId
		LEFT JOIN [Study].[Visit]                                                                                       ON [Study].[Visit].Id=[Study].[VisitSession].VisitId
		LEFT JOIN [Study].[StudVisitSchedule]                                                                           ON [Study].[StudVisitSchedule].Id=[Study].[Visit].StudyVisitScheduleId

	WHERE UserData.PrWorkflowInstance.TestIdentifier = @testIdentifier
	GROUP BY Assessment.Assessment.Id,
			Assessment.AssessmentTest.Id,
			Assessment.Assessment.DateOfAssessment,
			Assessment.Test.id,
			UserData.Person.Id,
			Assessment.Assessee.Id,
			Assessment.AssessmentSession.Id,
			Assessment.AssessmentSessionAttempt.Id,
			Assessment.Assessment.SessionDuration,
			Assessment.Test.[Name],
			Assessment.AssessmentTest.[Round],
			Assessment.AssessmentTest.Attempt,
			Assessment.AssessmentTest.Details,
			Assessment.TestCode.Phase,
			Assessment.TestCode.Name,
			Assessment.AssessmentTest.TaskVersion,
			UserData.Person.DOB,
			AssessmentSessionAttemptIssue.AssessmentSessionAttemptId,
			Userdata.Part.IQNumber,
			Assessment.Assessment.Age,
			UserData.PrWorkflowInstance.TestIdentifier,
			Assessment.Test.Descript";
			
			
			string sqlConnString = string.Format("Server={0};Database={1};User Id={2};Password={3};Authentication={4};Connection Timeout={5};", dbserver, database, username, password, authentication, "30");

			SqlDataAdapter da = new SqlDataAdapter(query, sqlConnString);
			da.SelectCommand.Parameters.AddWithValue("@testIdentifier", WebService.TestIdentifier);
			
			//Send the query to the database and store the results in a DataTable, the loop here will allow for the situation
			//where the results take longer than usual to be processed and appear in the Database.
			do
			{
				Delay.Duration(30000);
				
				using (da)
				{
					da.Fill(dt);
				}
				
				Report.Info("Rows found by query: " + dt.Rows.Count.ToString());
				
			} while (dt.Rows.Count < 1);
			
		}
		
		
		/// <summary>
		/// Getting ResetPassword from DB
		/// </summary>
		[UserCodeMethod]
		public static void GetRestToken(string dbserver, string database, string username, string password, string authentication, string key)
		{
			dt.Reset();
			
			// QueryDB
			string query = @"SELECT
		      resetpasswordtoken,username
              from [UserData].[User]
              where username = @key";
			
			//Connecting to SQL DB:
			string sqlConnString = string.Format("Server={0};Database={1};User Id={2};Password={3};Authentication={4};Connection Timeout={5};", dbserver, database, username, password, authentication, "30");
			//CreateObject:
			SqlDataAdapter da = new SqlDataAdapter(query, sqlConnString);
			da.SelectCommand.Parameters.AddWithValue("@key", key);
			// Get the data from DB
			using (da)
			{
				da.Fill(dt);
			}
			ResetToken = dt.Rows[0][0].ToString();
			string TokenKey = dt.Rows[0][1].ToString();
			Report.Log(ReportLevel.Info, "Reset Token: " + ResetToken + "Username: " +  TokenKey );
			
		}
		
		
		/// <summary>
		/// This method is for  validating the DCT move 
		/// </summary>
		[UserCodeMethod]
		public static void ValidateDCTMoved(string dbserver, string database, string username, string password, string authentication, string testIdentifier)
		{
		 
	
			dt.Reset();
			
			
			// QueryDB
			string query = @"SELECT 
                           TestIdentifier
                          ,[MoveOrigTestIdentifier]
                          ,[MovePrevTestIdentifier]
                           FROM [UserData].[PRWorkflowInstance]
                           where MovePrevTestIdentifier = @testIdentifier";
			do{
			Delay.Duration(30000);
			Report.Info( " Waiting for TestIdentifier"); 
			
			//Connecting to SQL DB:
			string sqlConnString = string.Format("Server={0};Database={1};User Id={2};Password={3};Authentication={4};Connection Timeout={5};", dbserver, database, username, password, authentication, "30");
			//CreateObject:
			SqlDataAdapter da = new SqlDataAdapter(query, sqlConnString);
			da.SelectCommand.Parameters.AddWithValue("@testIdentifier", Guid.Parse(testIdentifier));
			
			// Get the data from DB
			
		     using (da)  
					
			da.Fill(dt);
			
			
				} while ( dt.Rows.Count < 1);
				
		
			
			
			string  N_TestIdentifier  = dt.Rows[0][0].ToString();
			string MoveOrigTestIdentifier = dt.Rows[0][1].ToString();
			string MovePrevTestIdentifier = dt.Rows[0][2].ToString();
					
			Report.Log(ReportLevel.Info,  "NewTestIdentifier: " + "  " + N_TestIdentifier);
		    Report.Log(ReportLevel.Info,  "MoveOrigTestIdentifier: " + "  " +   MoveOrigTestIdentifier);
			Report.Log(ReportLevel.Info,  "MovePrevTestIdentifier" + " " + MovePrevTestIdentifier);
				
			
			
			
			
			
			
			        }
		
		}
          
     	}
	
	
	  
		
			
		
	
	
	



	



