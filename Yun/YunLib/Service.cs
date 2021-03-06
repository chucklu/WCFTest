﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YunLib
{
    public class Service : IService
    {
        public DataTable SelectProjectByUser(string userName)
        {
            DataTable dataTable = DAOManager.Instance.SelectProjectByUser(userName);
            dataTable.TableName = "DataTable";
            return dataTable;
        }

        public DataTable SelectDeviceByProject(string projectName)
        {
            DataTable dataTable = DAOManager.Instance.SelectDeviceByProject(projectName);
            dataTable.TableName = "DataTable";
            return dataTable;
        }

        public DataTable SelectSensorByProject(string projectName)
        {
            DataTable dataTable = DAOManager.Instance.SelectSensorByProject(projectName);
            dataTable.TableName = "DataTable";
            return dataTable;
        }

        public DataTable SelectProject()
        {
            DataTable dataTable = DAOManager.Instance.SelectProject();
            dataTable.TableName = "DataTable";
            return dataTable;
        }

        public DataTable SelectUnitByProject(string projectName)
        {
            DataTable dataTable = DAOManager.Instance.SelectUnitByProject(projectName);
            dataTable.TableName = "DataTable";
            return dataTable;
        }

        public DataTable SelectProjectSensorByProjectUnit(int projectUnitID)
        {
            DataTable dataTable = DAOManager.Instance.SelectProjectSensorByProjectUnit(projectUnitID);
            dataTable.TableName = "DataTable";
            return dataTable;
        }

        public DataTable SelectChannelSensorByProjectDevice(int projectDeviceID)
        {
            DataTable dataTable = DAOManager.Instance.SelectChannelSensorByProjectDeviceID(projectDeviceID);
            dataTable.TableName = "DataTable";
            return dataTable;
        }

        public DataTable SelectUser()
        {
            DataTable dataTable = DAOManager.Instance.SelectUser();
            dataTable.TableName = "DataTable";
            return dataTable;
        }

        public DataTable SelectDevice()
        {
            DataTable dataTable = DAOManager.Instance.SelectDevice();
            dataTable.TableName = "DataTable";
            return dataTable;
        }

        public DataTable SelectSensor()
        {
            DataTable dataTable = DAOManager.Instance.SelectSensor();
            dataTable.TableName = "DataTable";
            return dataTable;
        }

        public DataTable SelectUnit()
        {
            DataTable dataTable = DAOManager.Instance.SelectUnit();
            dataTable.TableName = "DataTable";
            return dataTable;
        }
    }
}
