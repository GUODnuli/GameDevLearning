using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5_7UserInfo
{
    public string userName;
    public string password;
    public string rePassword;
    public bool isMan;

    public L5_7UserInfo(string userName, string password, bool isMan)
    {
        this.userName = userName ?? throw new ArgumentNullException(nameof(userName));
        this.password = password ?? throw new ArgumentNullException(nameof(password));
        this.isMan = isMan;
    }
}
public class GameManager
{
    private static GameManager instance;

    public List<L5_7UserInfo> UserInfos = new List<L5_7UserInfo>();

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
                return instance;
            } else
            {
                return instance;
            }
        }
    }

    public void SaveUserInfo(L5_7UserInfo userInfo)
    {
        UserInfos.Add(userInfo);
    }

    public L5_7UserInfo GetUserInfo(string userName)
    {
        for(int i = 0; i < UserInfos.Count; i++)
        {
            if (UserInfos[i].userName == userName)
            {
                return UserInfos[i];
            }
        }

        return null;
    }
}
