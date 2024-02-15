using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class DataBaseConnector
    {
        public DataBaseConnector() { }

        /// <summary>
        /// Connects to the server
        /// </summary>
        /// <exception cref="ConnectException"></exception>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// var db = new DataBaseConnector(){...};
        /// try
        /// {
        ///     db.Connect();
        /// }
        /// catch (ConnectException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// </code>
        /// </example>
        public void Connect() 
        {
            try
            {

            }
            catch (ConnectException)
            {
                throw;
            }
        }

        /// <summary>
        /// Disables connection to the server
        /// </summary>
        /// <exception cref="DisconnectException"></exception>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// var db = new DataBaseConnector(){...};
        /// try
        /// {
        ///     db.Connect();
        ///     db.Disconnect();
        /// }
        /// catch (ConnectException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// catch (DisconnectException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// </code>
        /// </example>
        public void Disconnect()
        {
            try
            {
                
            }
            catch (DisconnectException)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs authentication with the server
        /// </summary>
        /// <exception cref="AuthenticateException"></exception>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// var db = new DataBaseConnector(){...};
        /// try
        /// {
        ///     db.Connect();
        ///     db.Authenticate();
        ///     db.Disconnect();
        /// }
        /// catch (ConnectException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// catch (AuthenticateException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// catch (DisconnectException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// </code>
        /// </example>
        public void Authenticate()
        {
            try
            {

            }
            catch (AuthenticateException)
            {
                throw;
            }
        }

        /// <summary>
        /// Adds data to the database
        /// </summary>
        /// <param name="obj">The object with which further manipulations will occur</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// var db = new DataBaseConnector(){...};
        /// try
        /// {
        ///     db.Connect();
        ///     db.Insert(new object());
        ///     db.Authenticate();
        ///     db.Disconnect();
        /// }
        /// catch (ConnectException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// catch (AuthenticateException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// catch (DisconnectException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// </code>
        /// </example>
        public void Insert(object obj) { }

        /// <summary>
        /// Updates data in the database
        /// </summary>
        /// <param name="obj">The object with which further manipulations will occur</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// var db = new DataBaseConnector(){...};
        /// try
        /// {
        ///     db.Connect();
        ///     db.Update(new object());
        ///     db.Authenticate();
        ///     db.Disconnect();
        /// }
        /// catch (ConnectException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// catch (AuthenticateException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// catch (DisconnectException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// </code>
        /// </example>
        public void Update(object obj) { }

        /// <summary>
        /// Removes data from the database
        /// </summary>
        /// <param name="obj">The object with which further manipulations will occur</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// var db = new DataBaseConnector(){...};
        /// try
        /// {
        ///     db.Connect();
        ///     db.Delete(new object());
        ///     db.Authenticate();
        ///     db.Disconnect();
        /// }
        /// catch (ConnectException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// catch (AuthenticateException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// catch (DisconnectException e)
        /// {
        ///     MessageBox.Show(e.Message)
        /// }
        /// </code>
        /// </example>
        public void Delete(object obj) { }
    }
}
