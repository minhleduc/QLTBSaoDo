using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTBSaoDo.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Action",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Action", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppConfig",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfig", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonNhap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayNhap = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    NguoiNhap = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonNhap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Function",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Function", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Khoa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    NguoiDaiDien = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Detail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThietBi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(15,2)", nullable: false, defaultValue: 0m),
                    Stock = table.Column<int>(nullable: false, defaultValue: 0),
                    Details = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(type: "Date", nullable: true, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("Mã thiết bị", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(type: "Date", nullable: true, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phong",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    KhoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phong_Khoa_KhoaId",
                        column: x => x.KhoaId,
                        principalTable: "Khoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false),
                    FunctionId = table.Column<int>(nullable: false),
                    ActionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_Permission_Action_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Action",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permission_Function_FunctionId",
                        column: x => x.FunctionId,
                        principalTable: "Function",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permission_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonNhap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonNhapId = table.Column<int>(nullable: false),
                    ThietBiId = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false, defaultValue: 0),
                    Gia = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    NhaCungCapId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonNhap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietDonNhap_DonNhap_DonNhapId",
                        column: x => x.DonNhapId,
                        principalTable: "DonNhap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDonNhap_NhaCungCap_NhaCungCapId",
                        column: x => x.NhaCungCapId,
                        principalTable: "NhaCungCap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDonNhap_ThietBi_ThietBiId",
                        column: x => x.ThietBiId,
                        principalTable: "ThietBi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThietBiDanhMuc",
                columns: table => new
                {
                    ThietBiId = table.Column<int>(nullable: false),
                    DanhMucId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThietBiDanhMuc", x => new { x.ThietBiId, x.DanhMucId });
                    table.ForeignKey(
                        name: "FK_ThietBiDanhMuc_DanhMuc_DanhMucId",
                        column: x => x.DanhMucId,
                        principalTable: "DanhMuc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThietBiDanhMuc_ThietBi_ThietBiId",
                        column: x => x.ThietBiId,
                        principalTable: "ThietBi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThietBiLoai",
                columns: table => new
                {
                    ThietBiId = table.Column<int>(nullable: false),
                    LoaiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThietBiLoai", x => new { x.ThietBiId, x.LoaiId });
                    table.ForeignKey(
                        name: "FK_ThietBiLoai_Loai_LoaiId",
                        column: x => x.LoaiId,
                        principalTable: "Loai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThietBiLoai_ThietBi_ThietBiId",
                        column: x => x.ThietBiId,
                        principalTable: "ThietBi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GVQuanLy",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    KhoaId = table.Column<int>(nullable: false),
                    PhongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GVQuanLy", x => new { x.UserId, x.KhoaId, x.PhongId });
                    table.ForeignKey(
                        name: "FK_GVQuanLy_Khoa_KhoaId",
                        column: x => x.KhoaId,
                        principalTable: "Khoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GVQuanLy_Phong_PhongId",
                        column: x => x.PhongId,
                        principalTable: "Phong",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GVQuanLy_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThietBiPhong",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThietBiId = table.Column<int>(nullable: false),
                    PhongId = table.Column<int>(nullable: false),
                    TenThietBi = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThietBiPhong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThietBiPhong_Phong_PhongId",
                        column: x => x.PhongId,
                        principalTable: "Phong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThietBiPhong_ThietBi_ThietBiId",
                        column: x => x.ThietBiId,
                        principalTable: "ThietBi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TinhTrang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThietBiPhongId = table.Column<int>(nullable: false),
                    HienTrang = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Tốt"),
                    ChiTiet = table.Column<string>(nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "Date", nullable: true, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhTrang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TinhTrang_ThietBiPhong_ThietBiPhongId",
                        column: x => x.ThietBiPhongId,
                        principalTable: "ThietBiPhong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TSThanhLy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThietBiPhongId = table.Column<int>(nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(15, 2)", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSThanhLy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TSThanhLy_ThietBiPhong_ThietBiPhongId",
                        column: x => x.ThietBiPhongId,
                        principalTable: "ThietBiPhong",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonNhap_DonNhapId",
                table: "ChiTietDonNhap",
                column: "DonNhapId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonNhap_NhaCungCapId",
                table: "ChiTietDonNhap",
                column: "NhaCungCapId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonNhap_ThietBiId",
                table: "ChiTietDonNhap",
                column: "ThietBiId");

            migrationBuilder.CreateIndex(
                name: "IX_GVQuanLy_KhoaId",
                table: "GVQuanLy",
                column: "KhoaId");

            migrationBuilder.CreateIndex(
                name: "IX_GVQuanLy_PhongId",
                table: "GVQuanLy",
                column: "PhongId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GVQuanLy_UserId",
                table: "GVQuanLy",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permission_ActionId",
                table: "Permission",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_FunctionId",
                table: "Permission",
                column: "FunctionId");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_KhoaId",
                table: "Phong",
                column: "KhoaId");

            migrationBuilder.CreateIndex(
                name: "IX_ThietBiDanhMuc_DanhMucId",
                table: "ThietBiDanhMuc",
                column: "DanhMucId");

            migrationBuilder.CreateIndex(
                name: "IX_ThietBiLoai_LoaiId",
                table: "ThietBiLoai",
                column: "LoaiId");

            migrationBuilder.CreateIndex(
                name: "IX_ThietBiPhong_PhongId",
                table: "ThietBiPhong",
                column: "PhongId");

            migrationBuilder.CreateIndex(
                name: "IX_ThietBiPhong_ThietBiId",
                table: "ThietBiPhong",
                column: "ThietBiId");

            migrationBuilder.CreateIndex(
                name: "IX_TinhTrang_ThietBiPhongId",
                table: "TinhTrang",
                column: "ThietBiPhongId");

            migrationBuilder.CreateIndex(
                name: "IX_TSThanhLy_ThietBiPhongId",
                table: "TSThanhLy",
                column: "ThietBiPhongId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserName",
                table: "User",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfig");

            migrationBuilder.DropTable(
                name: "ChiTietDonNhap");

            migrationBuilder.DropTable(
                name: "GVQuanLy");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "ThietBiDanhMuc");

            migrationBuilder.DropTable(
                name: "ThietBiLoai");

            migrationBuilder.DropTable(
                name: "TinhTrang");

            migrationBuilder.DropTable(
                name: "TSThanhLy");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "DonNhap");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "Action");

            migrationBuilder.DropTable(
                name: "Function");

            migrationBuilder.DropTable(
                name: "DanhMuc");

            migrationBuilder.DropTable(
                name: "Loai");

            migrationBuilder.DropTable(
                name: "ThietBiPhong");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "ThietBi");

            migrationBuilder.DropTable(
                name: "Khoa");
        }
    }
}
