using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for LoginFac
/// </summary>
public class LoginFac
{
    string strSQL;

    public int _protectID { get; set; }
    public string _password { get; set; }
    public string _username { get; set; }

    DataAccess objDataAccess = new DataAccess();
    SqlCommand objCMD = new SqlCommand();
 
    
    public DataTable hentAlleBrugere()
    {
        strSQL = "SELECT fldFornavn, fldEfternavn, fldID FROM tblBrugerOpl ORDER BY fldID ASC";
        objCMD = new SqlCommand(strSQL);
        return objDataAccess.GetData(objCMD);
    } 

    public string GetSH1(string _password)
    {
        SHA1 algorithm = SHA1.Create();
        byte[] data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(_password));
        string sh1 = "";
        for (int i = 0; i < data.Length; i++)
        {
            sh1 += data[i].ToString().ToUpperInvariant();
        }
        return sh1;
    }

    public DataTable Login()
    {
        strSQL = "SELECT fldID, fldBrugernavn, fldPassword1, fldRolleID FROM tblBrugerOpl WHERE fldBrugernavn = @user and fldPassword1 = @pass";
        objCMD = new SqlCommand(strSQL);
        objCMD.Parameters.AddWithValue("@user", _username);

        objCMD.Parameters.AddWithValue("@pass", _password);

        return objDataAccess.GetData(objCMD);

    }

    public DataRow hentBruger(int ID)
    {
        strSQL = "SELECT fldID, fldRolleID, fldFornavn, fldEfternavn FROM tblBrugerOpl WHEre fldID=@ID";

        objCMD = new SqlCommand(strSQL);
        objCMD.Parameters.AddWithValue("@ID", ID);
        return objDataAccess.GetData(objCMD).Rows[0];
    }

}