/* Title:           Design Productivitgy Class
 * Date:            1-14-19
 * Author:          Terry Holmes
 * 
 * Description:     This is the class for Design Productivity */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace DesignProductivityDLL
{
    public class DesignProductivityClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        DesignProductivityDataSet aDesignProductivitDataSet;
        DesignProductivityDataSetTableAdapters.designproductivityTableAdapter aDesignProductivityTableAdapter;

        InsertDesignProductivityEntryTableAdapters.QueriesTableAdapter aInsertDesignProductivityTableAdapter;

        FindDesignEmployeeProductivityByDateRangeDataSet aFindDesignEmployeeProductivityByDateRangeDataSet;
        FindDesignEmployeeProductivityByDateRangeDataSetTableAdapters.FindDesignEmployeeProductivityByDateRangeTableAdapter aFindDesignEmployeeProductivityByDateRangeTableAdapter;

        FindDesignDepartmentProductivityByDateRangeDataSet aFindDesignDepartmentProductivityByDateRangeDataSet;
        FindDesignDepartmentProductivityByDateRangeDataSetTableAdapters.FindDesignDepartmentProductivityByDateRangeTableAdapter aFindDesignDepartmentProductivityByDateRangeTableAdapter;

        FindDesignTotalEmployeeProductivityHoursDataSet aFindDesignTotalEmployeeProductivityHoursDataSet;
        FindDesignTotalEmployeeProductivityHoursDataSetTableAdapters.FindDesignTotalEmployeeProductivityHoursTableAdapter aFindDesignTotalEmployeeProductivityHoursTableAdapter;

        FindDesignTotalDepartmentProductivityDataSet aFindDesignTotalDepartmentProductivityDataSet;
        FindDesignTotalDepartmentProductivityDataSetTableAdapters.FindDesignTotalDepartmentProductivityTableAdapter aFindDesignTotalDepartmentProductivityTableAdapter;

        FindDesignEmployeeTotalHoursDataSet aFindDesignEmployeeTotalHoursDataSet;
        FindDesignEmployeeTotalHoursDataSetTableAdapters.FindDesignEmployeeTotalHoursTableAdapter aFindDesignEmployeeTotalHoursTableAdapter;

        FindAllDesignEmployeeProductivityOverAWeekDataSet aFindAllDesignEmployeeProductivityOverAWeekDataSet;
        FindAllDesignEmployeeProductivityOverAWeekDataSetTableAdapters.FindAllDesignEmployeeProductivityOverAWeekTableAdapter aFindAllDesignEmployeeProductivityOverAWeekTableAdapter;

        FindDesignProductivityForVoidingDataSet aFindDesignProductivityForVoidingDataSet;
        FindDesignProductivityForVoidingDataSetTableAdapters.FindDesignProductivityForVoidingTableAdapter aFindDesignProductivityForVoidingTableAdapter;

        VoidDesignProductivityEntryTableAdapters.QueriesTableAdapter aVoidDesignProductivityTableAdapter;

        public bool VoidDesignProductivity(int intTransactionID)
        {
            bool blnFatalError = false;

            try
            {
                aVoidDesignProductivityTableAdapter = new VoidDesignProductivityEntryTableAdapters.QueriesTableAdapter();
                aVoidDesignProductivityTableAdapter.VoidDesignProductivity(intTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Productivity Class // Void Design Productivity " + Ex.Message);
            }

            return blnFatalError;
        }
        public FindDesignProductivityForVoidingDataSet FindDesignProducitivityForVoiding(int intEmployeeID, string strAssignedProjectID, DateTime datTransactionDate)
        {
            try
            {
                aFindDesignProductivityForVoidingDataSet = new FindDesignProductivityForVoidingDataSet();
                aFindDesignProductivityForVoidingTableAdapter = new FindDesignProductivityForVoidingDataSetTableAdapters.FindDesignProductivityForVoidingTableAdapter();
                aFindDesignProductivityForVoidingTableAdapter.Fill(aFindDesignProductivityForVoidingDataSet.FindDesignProductivityForVoiding, intEmployeeID, strAssignedProjectID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Productivity Class // Find Design Productivity For Voiding " + Ex.Message);
            }

            return aFindDesignProductivityForVoidingDataSet;
        }
        public FindAllDesignEmployeeProductivityOverAWeekDataSet FindAllDesignEmployeeProductivityOverAWeek(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAllDesignEmployeeProductivityOverAWeekDataSet = new FindAllDesignEmployeeProductivityOverAWeekDataSet();
                aFindAllDesignEmployeeProductivityOverAWeekTableAdapter = new FindAllDesignEmployeeProductivityOverAWeekDataSetTableAdapters.FindAllDesignEmployeeProductivityOverAWeekTableAdapter();
                aFindAllDesignEmployeeProductivityOverAWeekTableAdapter.Fill(aFindAllDesignEmployeeProductivityOverAWeekDataSet.FindAllDesignEmployeeProductivityOverAWeek, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Productivity Class // Find All Design Employee Productivity Over A Week " + Ex.Message);
            }

            return aFindAllDesignEmployeeProductivityOverAWeekDataSet;
        }
        public FindDesignEmployeeTotalHoursDataSet FindDesignEmployeeTotalHours(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDesignEmployeeTotalHoursDataSet = new FindDesignEmployeeTotalHoursDataSet();
                aFindDesignEmployeeTotalHoursTableAdapter = new FindDesignEmployeeTotalHoursDataSetTableAdapters.FindDesignEmployeeTotalHoursTableAdapter();
                aFindDesignEmployeeTotalHoursTableAdapter.Fill(aFindDesignEmployeeTotalHoursDataSet.FindDesignEmployeeTotalHours, intEmployeeID, datStartDate, datEndDate);

            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Productivity Class // Find Design Employee Total Hours " + Ex.Message);
            }

            return aFindDesignEmployeeTotalHoursDataSet;
        }
        public FindDesignTotalDepartmentProductivityDataSet FindDesignTotalDepartmentProductivity(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDesignTotalDepartmentProductivityDataSet = new FindDesignTotalDepartmentProductivityDataSet();
                aFindDesignTotalDepartmentProductivityTableAdapter = new FindDesignTotalDepartmentProductivityDataSetTableAdapters.FindDesignTotalDepartmentProductivityTableAdapter();
                aFindDesignTotalDepartmentProductivityTableAdapter.Fill(aFindDesignTotalDepartmentProductivityDataSet.FindDesignTotalDepartmentProductivity, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Productivity Class // Find Design Total Department Productivity " + Ex.Message);
            }

            return aFindDesignTotalDepartmentProductivityDataSet;
        }
        public FindDesignTotalEmployeeProductivityHoursDataSet FindDesignTotalEmployeeProductivityHours(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDesignTotalEmployeeProductivityHoursDataSet = new FindDesignTotalEmployeeProductivityHoursDataSet();
                aFindDesignTotalEmployeeProductivityHoursTableAdapter = new FindDesignTotalEmployeeProductivityHoursDataSetTableAdapters.FindDesignTotalEmployeeProductivityHoursTableAdapter();
                aFindDesignTotalEmployeeProductivityHoursTableAdapter.Fill(aFindDesignTotalEmployeeProductivityHoursDataSet.FindDesignTotalEmployeeProductivityHours, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Productivity Class // Find Design Total Employee Productivity Hours " + Ex.Message);
            }

            return aFindDesignTotalEmployeeProductivityHoursDataSet;
        }
        public FindDesignDepartmentProductivityByDateRangeDataSet FindDesignDepartmentProductivityByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDesignDepartmentProductivityByDateRangeDataSet = new FindDesignDepartmentProductivityByDateRangeDataSet();
                aFindDesignDepartmentProductivityByDateRangeTableAdapter = new FindDesignDepartmentProductivityByDateRangeDataSetTableAdapters.FindDesignDepartmentProductivityByDateRangeTableAdapter();
                aFindDesignDepartmentProductivityByDateRangeTableAdapter.Fill(aFindDesignDepartmentProductivityByDateRangeDataSet.FindDesignDepartmentProductivityByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Productivity Class // Find Design Department Productivity By Date Range " + Ex.Message);
            }

            return aFindDesignDepartmentProductivityByDateRangeDataSet;
        }
        public FindDesignEmployeeProductivityByDateRangeDataSet FindDesignEmployeeProductivityByDateRange(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDesignEmployeeProductivityByDateRangeDataSet = new FindDesignEmployeeProductivityByDateRangeDataSet();
                aFindDesignEmployeeProductivityByDateRangeTableAdapter = new FindDesignEmployeeProductivityByDateRangeDataSetTableAdapters.FindDesignEmployeeProductivityByDateRangeTableAdapter();
                aFindDesignEmployeeProductivityByDateRangeTableAdapter.Fill(aFindDesignEmployeeProductivityByDateRangeDataSet.FindDesignEmployeeProductivityByDateRange, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Productivity Class // Find Design Employee Productivity By Date Range " + Ex.Message);
            }

            return aFindDesignEmployeeProductivityByDateRangeDataSet;
        }
        public bool InsertDesignProductivity(int intProjectID, int intEmployeeID, int intTaskID, decimal decTotalHours, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertDesignProductivityTableAdapter = new InsertDesignProductivityEntryTableAdapters.QueriesTableAdapter();
                aInsertDesignProductivityTableAdapter.InsertDesignProductivity(intProjectID, intEmployeeID, intTaskID, decTotalHours, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Productivity Class // Insert Design Productivity " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public DesignProductivityDataSet GetDesignProductivityInfo()
        {
            try
            {
                aDesignProductivitDataSet = new DesignProductivityDataSet();
                aDesignProductivityTableAdapter = new DesignProductivityDataSetTableAdapters.designproductivityTableAdapter();
                aDesignProductivityTableAdapter.Fill(aDesignProductivitDataSet.designproductivity);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Productivity Class // Get Design Productivity Info " + Ex.Message);
            }

            return aDesignProductivitDataSet;
        }
        public void UpdateDesignProductivityDB(DesignProductivityDataSet aDesignProductivitDataSet)
        {
            try
            {
                aDesignProductivityTableAdapter = new DesignProductivityDataSetTableAdapters.designproductivityTableAdapter();
                aDesignProductivityTableAdapter.Update(aDesignProductivitDataSet.designproductivity);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Productivity Class // Update Design Productivity DB " + Ex.Message);
            }
        }
    }
}
