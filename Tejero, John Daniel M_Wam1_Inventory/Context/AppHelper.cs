using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tejero__John_Daniel_M_Wam1_Inventory.Context;
using Tejero__John_Daniel_M_Wam1_Inventory.Database.Context;

public static class AppHelper
{
    public static SalesInventoryContext db = new SalesInventoryContext();
    public static AuthContext auth = new AuthContext();

    public static bool nameIsValid(string name)
    {
        string namePattern = @"^[A-Za-z]+(([' -][A-Za-z])?[A-Za-z]*)*$";
        return Regex.IsMatch(name, namePattern);
    }
}