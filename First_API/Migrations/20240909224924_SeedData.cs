using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace First_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepatmentName", "Description" },
                values: new object[,]
                {
                    { 1, " Department 1", "description1" },
                    { 2, " Department 2", "description2" },
                    { 3, " Department 3", "description3" },
                    { 4, " Department 4", "description4" },
                    { 5, " Department 5", "description5" },
                    { 6, " Department 6", "description6" },
                    { 7, " Department 7", "description7" },
                    { 8, " Department 8", "description8" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DepartmentId", "Email", "EmpName", "Salary" },
                values: new object[,]
                {
                    { 1, 7, "emp1@mail.com", "emp name 1", 28365 },
                    { 2, 6, "emp2@mail.com", "emp name 2", 29995 },
                    { 3, 2, "emp3@mail.com", "emp name 3", 28033 },
                    { 4, 1, "emp4@mail.com", "emp name 4", 28865 },
                    { 5, 2, "emp5@mail.com", "emp name 5", 26619 },
                    { 6, 2, "emp6@mail.com", "emp name 6", 25598 },
                    { 7, 3, "emp7@mail.com", "emp name 7", 25340 },
                    { 8, 7, "emp8@mail.com", "emp name 8", 27119 },
                    { 9, 6, "emp9@mail.com", "emp name 9", 25650 },
                    { 10, 7, "emp10@mail.com", "emp name 10", 25618 },
                    { 11, 7, "emp11@mail.com", "emp name 11", 26847 },
                    { 12, 4, "emp12@mail.com", "emp name 12", 27439 },
                    { 13, 3, "emp13@mail.com", "emp name 13", 27026 },
                    { 14, 4, "emp14@mail.com", "emp name 14", 25737 },
                    { 15, 3, "emp15@mail.com", "emp name 15", 28506 },
                    { 16, 4, "emp16@mail.com", "emp name 16", 29914 },
                    { 17, 1, "emp17@mail.com", "emp name 17", 26971 },
                    { 18, 6, "emp18@mail.com", "emp name 18", 25809 },
                    { 19, 2, "emp19@mail.com", "emp name 19", 27248 },
                    { 20, 5, "emp20@mail.com", "emp name 20", 26584 },
                    { 21, 4, "emp21@mail.com", "emp name 21", 29014 },
                    { 22, 1, "emp22@mail.com", "emp name 22", 26343 },
                    { 23, 7, "emp23@mail.com", "emp name 23", 28882 },
                    { 24, 5, "emp24@mail.com", "emp name 24", 29460 },
                    { 25, 5, "emp25@mail.com", "emp name 25", 29756 },
                    { 26, 2, "emp26@mail.com", "emp name 26", 28959 },
                    { 27, 7, "emp27@mail.com", "emp name 27", 28373 },
                    { 28, 3, "emp28@mail.com", "emp name 28", 29964 },
                    { 29, 2, "emp29@mail.com", "emp name 29", 26063 },
                    { 30, 7, "emp30@mail.com", "emp name 30", 25339 },
                    { 31, 7, "emp31@mail.com", "emp name 31", 25625 },
                    { 32, 6, "emp32@mail.com", "emp name 32", 28619 },
                    { 33, 7, "emp33@mail.com", "emp name 33", 26113 },
                    { 34, 7, "emp34@mail.com", "emp name 34", 29928 },
                    { 35, 7, "emp35@mail.com", "emp name 35", 27812 },
                    { 36, 5, "emp36@mail.com", "emp name 36", 27575 },
                    { 37, 3, "emp37@mail.com", "emp name 37", 26594 },
                    { 38, 6, "emp38@mail.com", "emp name 38", 28210 },
                    { 39, 6, "emp39@mail.com", "emp name 39", 27019 },
                    { 40, 6, "emp40@mail.com", "emp name 40", 25224 },
                    { 41, 3, "emp41@mail.com", "emp name 41", 28646 },
                    { 42, 1, "emp42@mail.com", "emp name 42", 28146 },
                    { 43, 3, "emp43@mail.com", "emp name 43", 25919 },
                    { 44, 6, "emp44@mail.com", "emp name 44", 28759 },
                    { 45, 1, "emp45@mail.com", "emp name 45", 29638 },
                    { 46, 7, "emp46@mail.com", "emp name 46", 25495 },
                    { 47, 5, "emp47@mail.com", "emp name 47", 26678 },
                    { 48, 2, "emp48@mail.com", "emp name 48", 27118 },
                    { 49, 1, "emp49@mail.com", "emp name 49", 29454 },
                    { 50, 1, "emp50@mail.com", "emp name 50", 29556 },
                    { 51, 6, "emp51@mail.com", "emp name 51", 29824 },
                    { 52, 6, "emp52@mail.com", "emp name 52", 25714 },
                    { 53, 3, "emp53@mail.com", "emp name 53", 29344 },
                    { 54, 7, "emp54@mail.com", "emp name 54", 25595 },
                    { 55, 7, "emp55@mail.com", "emp name 55", 29970 },
                    { 56, 3, "emp56@mail.com", "emp name 56", 29027 },
                    { 57, 6, "emp57@mail.com", "emp name 57", 26951 },
                    { 58, 1, "emp58@mail.com", "emp name 58", 26743 },
                    { 59, 2, "emp59@mail.com", "emp name 59", 29714 },
                    { 60, 4, "emp60@mail.com", "emp name 60", 26077 },
                    { 61, 4, "emp61@mail.com", "emp name 61", 29035 },
                    { 62, 2, "emp62@mail.com", "emp name 62", 28118 },
                    { 63, 5, "emp63@mail.com", "emp name 63", 25515 },
                    { 64, 5, "emp64@mail.com", "emp name 64", 28815 },
                    { 65, 4, "emp65@mail.com", "emp name 65", 26866 },
                    { 66, 7, "emp66@mail.com", "emp name 66", 29102 },
                    { 67, 4, "emp67@mail.com", "emp name 67", 26870 },
                    { 68, 7, "emp68@mail.com", "emp name 68", 29840 },
                    { 69, 5, "emp69@mail.com", "emp name 69", 25694 },
                    { 70, 6, "emp70@mail.com", "emp name 70", 25590 },
                    { 71, 5, "emp71@mail.com", "emp name 71", 25730 },
                    { 72, 2, "emp72@mail.com", "emp name 72", 25137 },
                    { 73, 1, "emp73@mail.com", "emp name 73", 28982 },
                    { 74, 2, "emp74@mail.com", "emp name 74", 25843 },
                    { 75, 3, "emp75@mail.com", "emp name 75", 29176 },
                    { 76, 4, "emp76@mail.com", "emp name 76", 27998 },
                    { 77, 3, "emp77@mail.com", "emp name 77", 27310 },
                    { 78, 6, "emp78@mail.com", "emp name 78", 25608 },
                    { 79, 5, "emp79@mail.com", "emp name 79", 26486 },
                    { 80, 2, "emp80@mail.com", "emp name 80", 25062 },
                    { 81, 7, "emp81@mail.com", "emp name 81", 27557 },
                    { 82, 5, "emp82@mail.com", "emp name 82", 27369 },
                    { 83, 6, "emp83@mail.com", "emp name 83", 29713 },
                    { 84, 1, "emp84@mail.com", "emp name 84", 25611 },
                    { 85, 7, "emp85@mail.com", "emp name 85", 25249 },
                    { 86, 1, "emp86@mail.com", "emp name 86", 27628 },
                    { 87, 3, "emp87@mail.com", "emp name 87", 28374 },
                    { 88, 1, "emp88@mail.com", "emp name 88", 28384 },
                    { 89, 2, "emp89@mail.com", "emp name 89", 28486 },
                    { 90, 2, "emp90@mail.com", "emp name 90", 26238 },
                    { 91, 6, "emp91@mail.com", "emp name 91", 29393 },
                    { 92, 2, "emp92@mail.com", "emp name 92", 26355 },
                    { 93, 4, "emp93@mail.com", "emp name 93", 26202 },
                    { 94, 7, "emp94@mail.com", "emp name 94", 29888 },
                    { 95, 6, "emp95@mail.com", "emp name 95", 29764 },
                    { 96, 2, "emp96@mail.com", "emp name 96", 29194 },
                    { 97, 4, "emp97@mail.com", "emp name 97", 26726 },
                    { 98, 2, "emp98@mail.com", "emp name 98", 29857 },
                    { 99, 2, "emp99@mail.com", "emp name 99", 28568 },
                    { 100, 5, "emp100@mail.com", "emp name 100", 29824 },
                    { 101, 2, "emp101@mail.com", "emp name 101", 26406 },
                    { 102, 5, "emp102@mail.com", "emp name 102", 29309 },
                    { 103, 7, "emp103@mail.com", "emp name 103", 27925 },
                    { 104, 5, "emp104@mail.com", "emp name 104", 27749 },
                    { 105, 3, "emp105@mail.com", "emp name 105", 27874 },
                    { 106, 1, "emp106@mail.com", "emp name 106", 28078 },
                    { 107, 4, "emp107@mail.com", "emp name 107", 26991 },
                    { 108, 7, "emp108@mail.com", "emp name 108", 26153 },
                    { 109, 2, "emp109@mail.com", "emp name 109", 28799 },
                    { 110, 5, "emp110@mail.com", "emp name 110", 27356 },
                    { 111, 7, "emp111@mail.com", "emp name 111", 26303 },
                    { 112, 5, "emp112@mail.com", "emp name 112", 28673 },
                    { 113, 7, "emp113@mail.com", "emp name 113", 26105 },
                    { 114, 7, "emp114@mail.com", "emp name 114", 28553 },
                    { 115, 5, "emp115@mail.com", "emp name 115", 27034 },
                    { 116, 4, "emp116@mail.com", "emp name 116", 26605 },
                    { 117, 2, "emp117@mail.com", "emp name 117", 27681 },
                    { 118, 4, "emp118@mail.com", "emp name 118", 25299 },
                    { 119, 5, "emp119@mail.com", "emp name 119", 26218 },
                    { 120, 5, "emp120@mail.com", "emp name 120", 27081 },
                    { 121, 4, "emp121@mail.com", "emp name 121", 28706 },
                    { 122, 2, "emp122@mail.com", "emp name 122", 25342 },
                    { 123, 2, "emp123@mail.com", "emp name 123", 26354 },
                    { 124, 3, "emp124@mail.com", "emp name 124", 27587 },
                    { 125, 6, "emp125@mail.com", "emp name 125", 25047 },
                    { 126, 1, "emp126@mail.com", "emp name 126", 28997 },
                    { 127, 4, "emp127@mail.com", "emp name 127", 25841 },
                    { 128, 6, "emp128@mail.com", "emp name 128", 26219 },
                    { 129, 3, "emp129@mail.com", "emp name 129", 27773 },
                    { 130, 1, "emp130@mail.com", "emp name 130", 28878 },
                    { 131, 6, "emp131@mail.com", "emp name 131", 25525 },
                    { 132, 6, "emp132@mail.com", "emp name 132", 26528 },
                    { 133, 1, "emp133@mail.com", "emp name 133", 27202 },
                    { 134, 2, "emp134@mail.com", "emp name 134", 26793 },
                    { 135, 3, "emp135@mail.com", "emp name 135", 27427 },
                    { 136, 2, "emp136@mail.com", "emp name 136", 26638 },
                    { 137, 4, "emp137@mail.com", "emp name 137", 27020 },
                    { 138, 3, "emp138@mail.com", "emp name 138", 29130 },
                    { 139, 1, "emp139@mail.com", "emp name 139", 25800 },
                    { 140, 5, "emp140@mail.com", "emp name 140", 27440 },
                    { 141, 2, "emp141@mail.com", "emp name 141", 25163 },
                    { 142, 7, "emp142@mail.com", "emp name 142", 29521 },
                    { 143, 7, "emp143@mail.com", "emp name 143", 25295 },
                    { 144, 3, "emp144@mail.com", "emp name 144", 28333 },
                    { 145, 2, "emp145@mail.com", "emp name 145", 26550 },
                    { 146, 3, "emp146@mail.com", "emp name 146", 28737 },
                    { 147, 6, "emp147@mail.com", "emp name 147", 27352 },
                    { 148, 4, "emp148@mail.com", "emp name 148", 29752 },
                    { 149, 4, "emp149@mail.com", "emp name 149", 29227 },
                    { 150, 2, "emp150@mail.com", "emp name 150", 25182 },
                    { 151, 4, "emp151@mail.com", "emp name 151", 28363 },
                    { 152, 5, "emp152@mail.com", "emp name 152", 28439 },
                    { 153, 4, "emp153@mail.com", "emp name 153", 26130 },
                    { 154, 6, "emp154@mail.com", "emp name 154", 29845 },
                    { 155, 7, "emp155@mail.com", "emp name 155", 26964 },
                    { 156, 6, "emp156@mail.com", "emp name 156", 25118 },
                    { 157, 3, "emp157@mail.com", "emp name 157", 27361 },
                    { 158, 2, "emp158@mail.com", "emp name 158", 29041 },
                    { 159, 7, "emp159@mail.com", "emp name 159", 29667 },
                    { 160, 5, "emp160@mail.com", "emp name 160", 27375 },
                    { 161, 4, "emp161@mail.com", "emp name 161", 27129 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7);
        }
    }
}
