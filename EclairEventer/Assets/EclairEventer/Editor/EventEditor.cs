﻿using UnityEngine;
using UnityEditor;
using System.Collections;

namespace wararyo.EclairEventer
{
    public class EventEditor : EditorWindow
    {
        private int tab = 0;
        private int paneWidth = 256;//timelineの左側の幅

        [MenuItem("Window/EclairEventEditor")]
        static void Open()
        {
            EditorWindow.GetWindow<EventEditor>("EventEditor");
        }

        void OnGUI()
        {
            using (var horizontalScope = new EditorGUILayout.HorizontalScope("toolbar"))
            {
                tab = GUILayout.Toolbar(tab, new string[] { "Timeline", "Raw" }, EditorStyles.toolbarButton, GUILayout.Width(180));
                //GUILayout.Space(20);
                toolbarSpace(16);//こうしないとRawボタンの右側の線が表示されない
                using (new EditorGUI.DisabledScope(true)) GUILayout.Button("Play", EditorStyles.toolbarButton,GUILayout.Width(64));
                EditorGUILayout.Space();
            }
            if (tab == 0)//Timelineタブ
            {
                using (var rulerScope = new EditorGUILayout.HorizontalScope("toolbar"))
                {
                    GUILayout.Button("Add", EditorStyles.toolbarButton, GUILayout.Width(64));
                    toolbarSpace(paneWidth - 64 - 6);
                    //ここまで256px
                    EclairGUILayout.Ruler(3.95f, 5.55f);
                }
            }
            else//Rawタブ
            {
                EditorGUILayout.LabelField("こちらはRawタブとなっております。");
            }
        }

        private void toolbarSpace(int width = 6)
        {
            using (new EditorGUI.DisabledScope(true)) GUILayout.Button("", EditorStyles.toolbarButton, GUILayout.Width(width));
        }
    }
}
