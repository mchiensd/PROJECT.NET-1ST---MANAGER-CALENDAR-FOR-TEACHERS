using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLGV.Model
{
    class ConnecttoSQL
    {
       
        #region khai báo

private SqlConnection Conn;
private SqlCommand _cmd;
private string StrCon = null;
private string _error;

public string Error
{
get { return _error; }
set { _error = value; }
}

public SqlConnection Connection
{
get { return Conn; }
}

public SqlCommand CMD
{
get { return _cmd; }
set { _cmd = value; }
}
#endregion

public ConnecttoSQL()
{
    StrCon = @"Data Source=PHUNG-THANH;Initial Catalog=QuanLyMoiGiang;Integrated Security=True";
            Conn = new SqlConnection(StrCon);
}


#region phương thức
public bool OpenCon()
{
try
{
if (Conn.State == ConnectionState.Closed)
Conn.Open();
}
catch (Exception ex)
{
_error = ex.Message;
return false;
}
return true;
}
public bool CloseCon()
{
try
{
if (Conn.State == ConnectionState.Open)
Conn.Close();
}
catch (Exception ex)
{
_error = ex.Message;
return false;
}
return true;
}
#endregion
    }
}
