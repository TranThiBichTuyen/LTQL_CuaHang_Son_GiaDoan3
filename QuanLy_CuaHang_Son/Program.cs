namespace QuanLy_CuaHang_Son
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            //Application.Run(new Forms.frmLoaiSanPham());
            //Application.Run(new Forms.frmHangSanXuat());
            //Application.Run(new Forms.frmKhachHang());
            // Application.Run(new Forms.frmNhanVien());
             Application.Run(new Forms.frmSanPham());
        }
    }
}