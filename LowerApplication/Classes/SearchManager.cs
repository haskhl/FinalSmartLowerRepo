using System;
using System.Collections.Generic;
using System.Text;
using EasyStore.Forms.Search;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar.Controls;
using EasyStore.DAL.HR;
using EasyStore.DAL.Accounts;
using EasyStore.DAL.Accounting;
using EasyStore.DAL.Production;
using EasyStore.DAL.Core;
using EasyStore.DAL.Sales;
using EasyStore.DAL.Purchasing;

namespace EasyStore.Classes
{

    public enum TablesNames
    {
        Roles,
        Users,
        Privileges,
        ExpensesTypes,
        ExpensesRecords,
        JobTitles,
        Qualifications,
        EmployeesData,
        EmployeesSalaries,
        SalaryItems,
        EmployeesSalaryItems,
        CorporationData,
        Customers,
        Items,
        ItemsCategory,
        ItemsModel,
        ItemsUnit,
        Stores,
        Suppliers,
        SuppliersSpecialist,
        PurchaseOrderHeader,
        PurchaseOrderDetails
    }

    public class SearchManager
    {

        public SearchManager()
        {
            colIDName = null;
            colIDValue = null;
        }

        public static string colIDName { get; set; }
        public static object colIDValue { get; set; }

        static TablesNames tablesNames { get; set; }

        string[] Headers = new string[] { null };
        string[] Names = new string[] { null };
        string[] DataProperty = new string[] { null };

        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[] { null };

        public void FillDataGridView(DataGridViewX dgv, DataGridViewTextBoxColumn[] columns, string[] Headers, string[] Names, string[] DataProperty)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            for (int index = 0; index < columns.Length; index++)
            {
                //Initialize objects
                columns[index] = new DataGridViewTextBoxColumn();

                //Set columns properties
                columns[index].HeaderText = Headers[index];
                columns[index].Name = Names[index];
                columns[index].DataPropertyName = DataProperty[index];

                //Add columns to dgv_SearchResults
                dgv.Columns.Add(columns[index]);
            }










        }

        public void FillComboBox(ComboBoxEx cmb, params string[] _Headers)
        {
            cmb.Items.Clear();
            for (int index = 0; index < _Headers.Length; index++)
            {
                cmb.Items.Add(_Headers[index]);
            }

        }

        public void CustomizeSearch(string searchKey, TablesNames tableName)
        {
            frmSearch frm = new frmSearch(tableName);
            CustomizeSearch(searchKey, tableName, frm.dgvSearchResults, frm.cmbSearchBy);
            frm.ShowDialog();
        }

        private void SetArraysItems(TablesNames tableName, ComboBoxEx cmb)
        {
            switch (tableName)
            {

                case TablesNames.Roles:
                    {
                        Headers = new string[] { "كود ", "اسم المجموعة" };
                        Names = new string[] { "colRoleID", "colRoleName" };
                        DataProperty = new string[] { "RoleID", "RoleName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "اسم المجموعة");
                        colIDName = "colRoleID";
                        break;
                    }
                case TablesNames.Users:
                    {
                        Headers = new string[] { "كود ", "اسم المستخدم" };
                        Names = new string[] { "colUserID", "colUserName" };
                        DataProperty = new string[] { "UserID", "UserName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "اسم المستخدم");
                        colIDName = "colUserID";
                        break;
                    }
                case TablesNames.JobTitles:
                    {
                        Headers = new string[] { "كود ", "المسمى الوظيفي" };
                        Names = new string[] { "colJobTitleID", "colJobTitleName" };
                        DataProperty = new string[] { "JobTitleID", "JobTitleName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "المسمى الوظيفي");
                        colIDName = "colJobTitleID";
                        break;
                    }

                case TablesNames.Qualifications:
                    {
                        Headers = new string[] { "كود ", " المؤهل" };
                        Names = new string[] { "colQualificationID", "colQualificationName" };
                        DataProperty = new string[] { "QualificationID", "QualificationName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "المؤهل");
                        colIDName = "colQualificationID";
                        break;
                    }

                case TablesNames.EmployeesData:
                    {
                        Headers = new string[] { "كود ", "اســم  الموظف" };
                        Names = new string[] { "colEmployeeID", "colEmployeeName" };
                        DataProperty = new string[] { "EmployeeID", "EmployeeName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "اســم  الموظف");
                        colIDName = "colEmployeeID";
                        break;
                    }
                case TablesNames.SalaryItems:
                    {
                        Headers = new string[] { "كود ", "الاستحقاق والأستقطاع" };
                        Names = new string[] { "colSalaryItemID", "colSalaryItemName" };
                        DataProperty = new string[] { "SalaryItemID", "SalaryItemName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "الأستحقاق والاستقطاع");
                        colIDName = "colSalaryItemID";
                        break;
                    }
                case TablesNames.EmployeesSalaries:
                    {
                        Headers = new string[] { "كود ", "الموظف", "الوظيفة", "الشهر", "التاريخ", "المرتب الشهري" };
                        Names = new string[] { "colEmpSalaryID", "colEmployeeName", "colJobTitleName", "colMonthArbName", "colEmpSalaryDate", "colEmployeeSalary" };
                        DataProperty = new string[] { "EmpSalaryID", "EmployeeName", "JobTitleName", "MonthArbName", "EmpSalaryDate", "EmployeeSalary" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "أســـم الموظف");
                        colIDName = "colEmpSalaryID";
                        break;
                    }
                case TablesNames.EmployeesSalaryItems:
                    {
                        Headers = new string[] { "كود ","اسـم الموظـف" ,"القيمة","استحقاق واستقطاع" };
                        Names = new string[] { "colEmpSalaryItemID", "colEmployeeName", "colEmpSalaryItemValue", "colSalaryItemName" };
                        DataProperty = new string[] { "EmpSalaryItemID", "EmployeeName", "EmpSalaryItemValue", "SalaryItemName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "اســـم الموظــف");
                        colIDName = "colEmpSalaryItemID";
                        break;
                    }
                case TablesNames.ExpensesTypes:
                    {
                        Headers = new string[] { "كود ", "أنــواع المصاريــف" };
                        Names = new string[] { "colExpenseTypeID", "colExpenseTypeName" };
                        DataProperty = new string[] { "ExpenseTypeID", "ExpenseTypeName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "أنــواع المصاريــف");
                        colIDName = "colExpenseTypeID";
                        break;
                    }
                case TablesNames.ExpensesRecords:
                    {
                        Headers = new string[] { "كود ", "أنــواع المصاريــف", "تاريخ", "قيمة المصاريف" };
                        Names = new string[] { "colExpenseRecordID", "colExpenseTypeName", "colExpenseRecordDate", "colExpenseRecordCost" };
                        DataProperty = new string[] { "ExpenseRecordID", "ExpenseTypeName", "ExpenseRecordDate", "ExpenseRecordCost" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "أنــواع المصاريــف");
                        colIDName = "colExpenseRecordID";
                        break;
                    }

                
                case TablesNames.CorporationData:
                    {
                        Headers = new string[] { "كود ", " اسم الشركة" };
                        Names = new string[] { "colCorporationID", "colCorporationName" };
                        DataProperty = new string[] { "CorporationID", "CorporationName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, " اسم الشركة");
                        colIDName = "colCorporationID";
                        break;
                    }
                case TablesNames.Customers:
                    {
                        Headers = new string[] { "كود ", " اسم العمــيل" };
                        Names = new string[] { "colCustomerID", "colCustomerName" };
                        DataProperty = new string[] { "CustomerID", "CustomerName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "اسم العمــيل");
                        colIDName = "colCustomerID";
                        break;
                    }
                case TablesNames.Items:
                    {
                        Headers = new string[] { "كود ", " اسم الصنــف" ,"وحدة القياس"};
                        Names = new string[] { "colItemID", "colItemName" ,"ItemUnitName"};
                        DataProperty = new string[] { "ItemID", "ItemName","ItemUnitName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "اسم الصنــف");
                        colIDName = "colItemID";
                        break;
                    }
                case TablesNames.ItemsCategory:
                    {
                        Headers = new string[] { "كود ", " اسم قسم الأصنـاف" };
                        Names = new string[] { "colItemCategoryID", "colItemCategoryName" };
                        DataProperty = new string[] { "ItemCategoryID", "ItemCategoryName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "اسم قسم الأصنـاف");
                        colIDName = "colItemCategoryID";
                        break;
                    }
                case TablesNames.ItemsModel:
                    {
                        Headers = new string[] { "كود ", " اسم الماركـــة" };
                        Names = new string[] { "colItemModelID", "colItemModelName" };
                        DataProperty = new string[] { "ItemModelID", "ItemModelName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "اسم الماركـــة");
                        colIDName = "colItemModelID";
                        break;
                    }
                case TablesNames.ItemsUnit:
                    {
                        Headers = new string[] { "كود ", "اسم وحدة القيـاس" };
                        Names = new string[] { "colItemUnitID", "colItemUnitName" };
                        DataProperty = new string[] { "ItemUnitID", "ItemUnitName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "اسم وحدة القيـاس");
                        colIDName = "colItemUnitID";
                        break;
                    }
                case TablesNames.Stores:
                    {
                        Headers = new string[] { "كود ", "اســم المخـزن" };
                        Names = new string[] { "colStoreID", "colStoreName" };
                        DataProperty = new string[] { "StoreID", "StoreName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "اسم وحدة القيـاس");
                        colIDName = "colStoreID";
                        break;
                    }
                case TablesNames.Suppliers:
                    {
                        Headers = new string[] { "كود ", "اســم المــورد" };
                        Names = new string[] { "colSupplierID", "colSupplierName" };
                        DataProperty = new string[] { "SupplierID", "SupplierName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "اسم وحدة القيـاس");
                        colIDName = "colSupplierID";
                        break;
                    }
                case TablesNames.SuppliersSpecialist:
                    {
                        Headers = new string[] { "كود ", "اســم تخصص المــورد" };
                        Names = new string[] { "colSupplierSpecialistID", "colSupplierSpecialistName" };
                        DataProperty = new string[] { "SupplierSpecialistID", "SupplierSpecialistName" };
                        DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[DataProperty.Length];
                        FillComboBox(cmb, "اسم وحدة القيـاس");
                        colIDName = "colSupplierSpecialistID";
                        break;
                    }
                
            }
        }

        public void CustomizeSearch(string searchKey, TablesNames tableName, DataGridViewX dgv, ComboBoxEx cmb)
        {

            switch (tableName)
            {

                case TablesNames.Roles:
                    {
                        SetArraysItems(TablesNames.Roles, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = RolesDB.SearchRole(searchKey);

                        break;
                    }
                case TablesNames.Users:
                    {
                        SetArraysItems(TablesNames.Users, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = UsersDB.SearchUser(searchKey);

                        break;
                    }
                case TablesNames.JobTitles:
                    {
                        SetArraysItems(TablesNames.JobTitles, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = JobTitlesDB.SearchJobTitle(searchKey);
                        break;
                    }

                case TablesNames.Qualifications:
                    {
                        SetArraysItems(TablesNames.Qualifications, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = QualificationsDB.SearchQualification(searchKey);
                        break;
                    }

                case TablesNames.EmployeesData:
                    {
                        SetArraysItems(TablesNames.EmployeesData, cmb);

                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = EmployeesDataDB.SearchEmployeeData(searchKey);

                        break;
                    }
                case TablesNames.SalaryItems:
                    {
                        SetArraysItems(TablesNames.SalaryItems, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = SalaryItemsDB.SearchSalaryItem(searchKey);
                        break;
                    }
                case TablesNames.EmployeesSalaryItems:
                    {
                        SetArraysItems(TablesNames.EmployeesSalaryItems, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = EmployeesSalaryItemsDB.SearchEmployeeSalaryItem(searchKey);
                        break;
                    }
                case TablesNames.EmployeesSalaries:
                    {
                        SetArraysItems(TablesNames.EmployeesSalaries, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = EmployeesSalariesDB.SearchEmployeeSalary(searchKey);
                        break;
                    }
                case TablesNames.ExpensesTypes:
                    {
                        SetArraysItems(TablesNames.ExpensesTypes, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = ExpensesTypesDB.SearchExpenseType(searchKey);
                        break;
                    }
                case TablesNames.ExpensesRecords:
                    {
                        SetArraysItems(TablesNames.ExpensesRecords, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = ExpensesRecordsDB.SearchExpenseRecord(searchKey);
                        break;
                    }
               
                case TablesNames.CorporationData:
                    {
                        SetArraysItems(TablesNames.CorporationData, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = CorporationDataDB.SearchCorporationData(searchKey);
                        break;
                    }
                case TablesNames.Customers:
                    {
                        SetArraysItems(TablesNames.Customers, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = CustomersDB.SearchCustomer(searchKey);
                        break;
                    }
                case TablesNames.Items:
                    {
                        SetArraysItems(TablesNames.Items, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = ItemsDB.SearchItems(searchKey);
                        break;
                    }
                case TablesNames.ItemsCategory:
                    {
                        SetArraysItems(TablesNames.ItemsCategory, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = ItemsCategoryDB.SearchItemCategory(searchKey);
                        break;
                    }
                case TablesNames.ItemsModel:
                    {
                        SetArraysItems(TablesNames.ItemsModel, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = ItemsModelDB.SearchItemModel(searchKey);
                        break;
                    }
                case TablesNames.ItemsUnit:
                    {
                        SetArraysItems(TablesNames.ItemsUnit, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = ItemsUnitDB.SearchItemUnit(searchKey);
                        break;
                    }
                case TablesNames.Stores:
                    {
                        SetArraysItems(TablesNames.Stores, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = StoresDB.SearchStore(searchKey);
                        break;
                    }
                case TablesNames.Suppliers:
                    {
                        SetArraysItems(TablesNames.Suppliers, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = SuppliersDB.SearchSuppliers(searchKey);
                        break;
                    }
                case TablesNames.SuppliersSpecialist:
                    {
                        SetArraysItems(TablesNames.SuppliersSpecialist, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];
                        FillDataGridView(dgv, columns, Headers, Names, DataProperty);
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = SuppliersSpecialistDB.SearchSupplierSpecialist(searchKey);
                        break;
                    }
                
            }
        }

        public void CustomizeSearch(string searchKey, TablesNames tableName, frmSearch frm, ComboBoxEx cmb)
        {
            switch (tableName)
            {

                case TablesNames.Roles:
                    {
                        SetArraysItems(TablesNames.Roles, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = RolesDB.SearchRole(searchKey);

                        break;
                    }
                case TablesNames.Users:
                    {
                        SetArraysItems(TablesNames.Users, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = UsersDB.SearchUser(searchKey);

                        break;
                    }


                case TablesNames.JobTitles:
                    {
                        SetArraysItems(TablesNames.SalaryItems, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = JobTitlesDB.SearchJobTitle(searchKey);

                        break;
                    }

                case TablesNames.Qualifications:
                    {
                        SetArraysItems(TablesNames.SalaryItems, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = QualificationsDB.SearchQualification(searchKey);

                        break;
                    }

                case TablesNames.EmployeesData:
                    {
                        SetArraysItems(TablesNames.SalaryItems, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = EmployeesDataDB.SearchEmployeeData(searchKey);

                        break;
                    }
                case TablesNames.SalaryItems:
                    {
                        SetArraysItems(TablesNames.SalaryItems, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = SalaryItemsDB.SearchSalaryItem(searchKey);
                        break;
                    }
                case TablesNames.EmployeesSalaryItems:
                    {
                        SetArraysItems(TablesNames.EmployeesSalaryItems, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = EmployeesSalaryItemsDB.SearchEmployeeSalaryItem(searchKey);
                        break;
                    }
                case TablesNames.EmployeesSalaries:
                    {
                        SetArraysItems(TablesNames.EmployeesSalaries, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = EmployeesSalariesDB.SearchEmployeeSalary(searchKey);
                        break;
                    }
                case TablesNames.ExpensesTypes:
                    {
                        SetArraysItems(TablesNames.ExpensesTypes, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = ExpensesTypesDB.SearchExpenseType(searchKey);
                        break;
                    }
                case TablesNames.ExpensesRecords:
                    {
                        SetArraysItems(TablesNames.ExpensesRecords, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = ExpensesRecordsDB.SearchExpenseRecord(searchKey);
                        break;
                    }
                
                
                
                case TablesNames.CorporationData:
                    {
                        SetArraysItems(TablesNames.CorporationData, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = CorporationDataDB.SearchCorporationData(searchKey);
                        break;
                    }
                case TablesNames.Customers:
                    {
                        SetArraysItems(TablesNames.Customers, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = CustomersDB.SearchCustomer(searchKey);
                        break;
                    }
                case TablesNames.Items:
                    {
                        SetArraysItems(TablesNames.Items, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = ItemsDB.SearchItems(searchKey);
                        break;
                    }
                case TablesNames.ItemsCategory:
                    {
                        SetArraysItems(TablesNames.ItemsCategory, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = ItemsCategoryDB.SearchItemCategory(searchKey);
                        break;
                    }
                case TablesNames.ItemsModel:
                    {
                        SetArraysItems(TablesNames.ItemsModel, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = ItemsModelDB.SearchItemModel(searchKey);
                        break;
                    }
                case TablesNames.ItemsUnit:
                    {
                        SetArraysItems(TablesNames.ItemsUnit, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = ItemsUnitDB.SearchItemUnit(searchKey);
                        break;
                    }
                case TablesNames.Stores:
                    {
                        SetArraysItems(TablesNames.Stores, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = StoresDB.SearchStore(searchKey);
                        break;
                    }
                case TablesNames.Suppliers:
                    {
                        SetArraysItems(TablesNames.Suppliers, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = SuppliersDB.SearchSuppliers(searchKey);
                        break;
                    }
                case TablesNames.SuppliersSpecialist:
                    {
                        SetArraysItems(TablesNames.SuppliersSpecialist, cmb);
                        columns = new DataGridViewTextBoxColumn[Headers.Length];

                        FillDataGridView(frm.dgvSearchResults, columns, Headers, Names, DataProperty);
                        frm.dgvSearchResults.AutoGenerateColumns = false;
                        frm.dgvSearchResults.DataSource = SuppliersSpecialistDB.SearchSupplierSpecialist(searchKey);
                        break;
                    }
                 
            }
        }
    }

}
