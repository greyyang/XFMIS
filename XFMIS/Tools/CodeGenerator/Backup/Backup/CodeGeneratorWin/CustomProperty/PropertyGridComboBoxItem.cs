using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;

using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace CodeGeneratorWin.CustomProperty
{
    /// <summary>
    /// 选择数据库
    /// </summary>
    public class PropertyGridSelectDatabaseItem : ComboBoxItemTypeConvert
    {
        private readonly string _connectionString = ConfigurationManager.AppSettings["connectionStrings"];

        public IList<string> GetDatabases()
        {
            IList<string> list = new List<string>();
            Server server = new Server(new ServerConnection(new SqlConnection(_connectionString)));
            foreach (Database database in server.Databases)
            {

                if (database.Name == "master" ||
                    database.Name == "model" ||
                    database.Name == "msdb" ||
                    database.Name == "tempdb"
                    )
                    continue;

                list.Add(database.Name);
            }
            return list;
        }

        public override void GetConvertHash()
        {
            IList<string> list = GetDatabases();
            foreach (string s in list)
            {
                _hash.Add(s, s);
            }
        }
    }

    /// <summary>
    /// 自定义下拉列表
    /// </summary>
    public abstract class ComboBoxItemTypeConvert : TypeConverter
    {
        public Hashtable _hash;

        protected ComboBoxItemTypeConvert()
        {
            _hash = new Hashtable();

            GetConvertHash();
        }

        public abstract void GetConvertHash();

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            string[] ids = new string[_hash.Values.Count];

            int i = 0;

            foreach (DictionaryEntry myDE in _hash)
            {
                ids[i++] = (string)(myDE.Key);
            }

            return new StandardValuesCollection(ids);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object v)
        {
            if (v is string)
            {
                foreach (DictionaryEntry myDE in _hash)
                {
                    if (myDE.Value.Equals((v.ToString())))
                        return myDE.Key;
                }
            }
            return base.ConvertFrom(context, culture, v);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object v, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                foreach (DictionaryEntry myDE in _hash)
                {
                    if (myDE.Key.Equals(v))
                        return myDE.Value.ToString();
                }
                return "";
            }
            return base.ConvertTo(context, culture, v, destinationType);
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return false;
        }
    }
}