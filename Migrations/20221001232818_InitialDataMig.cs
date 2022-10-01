using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollApi.Migrations
{
    public partial class InitialDataMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "ActiveStatus", "Address", "BadgeNumber", "BloodGroupId", "DateOfBirth", "DesignationId", "Email", "EmergencyContact", "EmpFullName", "Emp_Id", "EmployeeTypeId", "EndDate", "FirstName", "GenderId", "HireDate", "ImageFile", "ImagePath", "InsertDate", "IsTrainee", "IsWorker", "LastName", "MaritialStatusId", "MiddleName", "NationalId", "Password", "Permanent", "PhoneNumber", "ReligionId", "SectionId" },
                values: new object[] { 1, false, "45 Ikotun", "12", 1, null, 1, "henrichukwudi@gmail.com", "23 Ur", "Henry Chukwudi", 0, 1, null, "Henry", 1, null, "null", "null", null, false, false, "Otunuya", 1, "Chukwudi", "NG", "Admin@123", null, "07035842901", 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
