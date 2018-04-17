﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace cln
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField]
        private Menu[] _menus;
        private Dictionary<Type, Menu> _typeToMenuMap;

        void Start()
        {
            _typeToMenuMap = new Dictionary<Type, Menu>();
            foreach (var menu in _menus)
            {
                _typeToMenuMap.Add(menu.GetType(), menu);
                menu.Close();
            }
            
            Show(typeof(MainMenu));
        }

        public void Show<T>(T menuType) where T : Type
        {
            _typeToMenuMap[menuType].Show();
        }

        public void Close<T>(T menuType) where T : Type
        {
            _typeToMenuMap[menuType].Close();
        }
    }
}