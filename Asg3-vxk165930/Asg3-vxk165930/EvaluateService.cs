using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg3_vxk165930
{
    class EvaluateService
    {
        public EvaluateService()
        {

        }

        /*This method reads the data from the file specified by the user into a list of records and returns all the read records*/
        public List<RecordDetails> readData(String inputFileName)
        {
            List<RecordDetails> allRecords = new List<RecordDetails>();
            String newLine;
            /*Read the file if it exits and save the results in a list of records*/
            System.IO.StreamReader file = new System.IO.StreamReader(inputFileName);
            try
            {
                while ((newLine = file.ReadLine()) != null)
                {
                    String[] line = newLine.Split('\t');
                    int index = 0;
                    RecordDetails newRecord = new RecordDetails();
                    newRecord.FirstName = line[index++];
                    newRecord.LastName = line[index++];
                    newRecord.MiddleInitial = line[index++];
                    newRecord.AddressLine1 = line[index++];
                    newRecord.AddressLine2 = line[index++];
                    newRecord.City = line[index++];
                    newRecord.State = line[index++];
                    newRecord.Zipcode = line[index++];
                    newRecord.Gender = line[index++];
                    newRecord.PhoneNumber = line[index++];
                    newRecord.Email = line[index++];
                    newRecord.ProofOfPurchase = line[index++];
                    newRecord.DateReceived = line[index++];
                    newRecord.StartTime = line[index++];
                    newRecord.EndTime = line[index++];
                    newRecord.BackSpaceCount = Convert.ToInt32(line[index++]);
                    allRecords.Add(newRecord);

                }

            }

            catch (Exception)
            {
                return null;
            }
            file.Close();
            return allRecords;
        }

        /*This method does all the evaluation needed and stores the results in a dictionary and returns it.*/
        public Dictionary<String, String> evaluationDetails(List<RecordDetails> allRecords)
            {
            Dictionary<String, String> evaluatonResults = new Dictionary<String, String>();
            int records = 0;
            double minEntry = 0;
            double maxEntry = 0;
            double avgEntry = 0;
            double minInt = 0;
            double maxInt = 0;
            double avgInt = 0;
            double totalTime = 0;
            int bsCount = 0;
            if(allRecords==null || allRecords.Count == 0)
            {
                return null;
            }

            records = allRecords.Count;

            double minEntrySeconds = Double.MaxValue;
            double maxEntrySeconds = Double.MinValue;
            double avgEntrySeconds = 0;
            double totalEntrySeconds = 0;
            double minIntSeconds = Double.MaxValue;
            double maxIntSeconds = Double.MinValue;
            double avgIntSeconds;
            double totalIntSeconds = 0;
            double totalTimeSeconds = 0;

            DateTime firstStart = DateTime.Now;
            DateTime lastEnd = DateTime.Now;
            Boolean isFirstRecord = false;

            /*The evaluation is done from here*/

            foreach(var newRecord in allRecords)
            {
                String startTime = newRecord.StartTime;
                String endTime = newRecord.EndTime;

                DateTime timeStarted = Convert.ToDateTime(startTime);
                DateTime timeEnded = Convert.ToDateTime(endTime);
                double timeDifference = (timeEnded - timeStarted).TotalSeconds;
                totalEntrySeconds += timeDifference;

                if(timeDifference < minEntrySeconds)
                {
                    minEntrySeconds = timeDifference;
                }
                if (timeDifference > maxEntrySeconds)
                {
                    maxEntrySeconds = timeDifference;
                }
                if (isFirstRecord == false)
                {
                    isFirstRecord = true;
                    firstStart = timeStarted;
                }
                else
                {
                    double timeDifference2 = (timeStarted - lastEnd).TotalSeconds;
                    totalIntSeconds += timeDifference2;

                    if (timeDifference2 < minIntSeconds)
                    {
                        minIntSeconds = timeDifference2;
                    }

                    if (timeDifference2 > maxIntSeconds)
                    {
                        maxIntSeconds = timeDifference2;
                    }

                }
                lastEnd = timeEnded;

                bsCount += newRecord.BackSpaceCount;
            }
            avgEntrySeconds = totalEntrySeconds / records;

            /*If there is only one record then the inter record times will be zero*/
            if (records < 2)
            {
                minIntSeconds = 0;
                maxIntSeconds = 0;
                avgIntSeconds = 0;
            }
            else
            {
                avgIntSeconds = totalIntSeconds / (records - 1);

            }
            
            totalTimeSeconds = (lastEnd - firstStart).TotalSeconds;
            minEntry = minEntrySeconds;
            maxEntry = maxEntrySeconds;
            avgEntry = avgEntrySeconds;
            minInt = minIntSeconds;
            maxInt = maxIntSeconds;
            avgInt = avgIntSeconds;
            totalTime = totalTimeSeconds;

            /*Saving the evaluation results in the dictionary*/

            evaluatonResults.Add("records",Convert.ToString(records));
            evaluatonResults.Add("minEntry", timeFormatForDisplay(minEntry));
            evaluatonResults.Add("maxEntry", timeFormatForDisplay(maxEntry));
            evaluatonResults.Add("avgEntry", timeFormatForDisplay(avgEntry));
            evaluatonResults.Add("minInt", timeFormatForDisplay(minInt));
            evaluatonResults.Add("maxInt", timeFormatForDisplay(maxInt));
            evaluatonResults.Add("avgInt", timeFormatForDisplay(avgInt));
            evaluatonResults.Add("totalTime", timeFormatForDisplay(totalTime));
            evaluatonResults.Add("bsCount", Convert.ToString(bsCount));

            return evaluatonResults;
            }

        /*This method is to write the evaluation results to a file specified by the user*/
        public void writeData(Dictionary<String,String> evaluationResults,String outputFileName)
        {
            ICollection<String> primaryKeys = evaluationResults.Keys;
            Dictionary<String, String> saveEvaluation = new Dictionary<String, String>();
            saveEvaluation.Add("records","Number of records");
            saveEvaluation.Add("minEntry", "Minimum entry time");
            saveEvaluation.Add("maxEntry", "Maximum entry time");
            saveEvaluation.Add("avgEntry", "Average entry time"); 
            saveEvaluation.Add("minInt", "Minimum inter-record time");
            saveEvaluation.Add("maxInt", "Maximum inter-record time");
            saveEvaluation.Add("avgInt", "Average inter-record time");
            saveEvaluation.Add("totalTime", "Total time");
            saveEvaluation.Add("bsCount", "Backspace count");

            /*Writing the evaluation reslts to a file specified by the user*/
            using (System.IO.StreamWriter file=new System.IO.StreamWriter(System.IO.Path.GetFullPath(outputFileName)))
            {
                foreach(var primaryKey in primaryKeys)
                {
                    String newLine = saveEvaluation[primaryKey] + " = " + evaluationResults[primaryKey];
                    file.WriteLine(newLine);
                }
            }

        }

        /*This method takes seconds as the input, which converts the seconds to minutes and seconds and returns a formatted string to display in the format MM:SS*/
        public String timeFormatForDisplay(double seconds)
        {
            String time="";
            if(seconds < 0)
            {
                return "00 : 00";
            }

            double mnts = seconds / 60;
            int MM = (seconds > 59) ? ((int)Math.Truncate((mnts))) : 0;
            double secs = MM*60;
            int SS = (int)Math.Abs(seconds-secs);

            /*Returns a time as a string in MM:SS format.*/
            time = (MM <10 ? "0"+ MM : "" + MM ) + " : "+ (SS <10 ? "0" + SS : "" + SS);
            return time;
        }
        
    }
}
