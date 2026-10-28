using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingTrack.Migrations
{
    /// <inheritdoc />
    public partial class CreateUser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDistributions_Books_BookId",
                table: "BookDistributions");

            migrationBuilder.DropForeignKey(
                name: "FK_BookDistributions_Governorates_GovernorateId",
                table: "BookDistributions");

            migrationBuilder.DropForeignKey(
                name: "FK_BookDistributions_Halls_HallId",
                table: "BookDistributions");

            migrationBuilder.DropForeignKey(
                name: "FK_BookDistributions_Trainers_TrainerId",
                table: "BookDistributions");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyReports_Trainers_TrainerId",
                table: "DailyReports");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Trainers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TrainerId",
                table: "DailyReports",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TrainerId",
                table: "BookDistributions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HallId",
                table: "BookDistributions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GovernorateId",
                table: "BookDistributions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "BookDistributions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BookDistributions_Books_BookId",
                table: "BookDistributions",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookDistributions_Governorates_GovernorateId",
                table: "BookDistributions",
                column: "GovernorateId",
                principalTable: "Governorates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookDistributions_Halls_HallId",
                table: "BookDistributions",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookDistributions_Trainers_TrainerId",
                table: "BookDistributions",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyReports_Trainers_TrainerId",
                table: "DailyReports",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDistributions_Books_BookId",
                table: "BookDistributions");

            migrationBuilder.DropForeignKey(
                name: "FK_BookDistributions_Governorates_GovernorateId",
                table: "BookDistributions");

            migrationBuilder.DropForeignKey(
                name: "FK_BookDistributions_Halls_HallId",
                table: "BookDistributions");

            migrationBuilder.DropForeignKey(
                name: "FK_BookDistributions_Trainers_TrainerId",
                table: "BookDistributions");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyReports_Trainers_TrainerId",
                table: "DailyReports");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Trainers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TrainerId",
                table: "DailyReports",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TrainerId",
                table: "BookDistributions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HallId",
                table: "BookDistributions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GovernorateId",
                table: "BookDistributions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "BookDistributions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_BookDistributions_Books_BookId",
                table: "BookDistributions",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookDistributions_Governorates_GovernorateId",
                table: "BookDistributions",
                column: "GovernorateId",
                principalTable: "Governorates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookDistributions_Halls_HallId",
                table: "BookDistributions",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookDistributions_Trainers_TrainerId",
                table: "BookDistributions",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyReports_Trainers_TrainerId",
                table: "DailyReports",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
