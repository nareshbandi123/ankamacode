﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AutomationSQLdm
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the AutomationSQLdmRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    [RepositoryFolder("7bd21acd-09e4-4c42-81c5-68b39ccd889b")]
    public partial class AutomationSQLdmRepository : RepoGenBaseFolder
    {
        static AutomationSQLdmRepository instance = new AutomationSQLdmRepository();
        AutomationSQLdmRepositoryFolders.IderaSQLDiagnosticManagerSQLdmRepoAppFolder _iderasqldiagnosticmanagersqldmrepo;

        /// <summary>
        /// Gets the singleton class instance representing the AutomationSQLdmRepository element repository.
        /// </summary>
        [RepositoryFolder("7bd21acd-09e4-4c42-81c5-68b39ccd889b")]
        public static AutomationSQLdmRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public AutomationSQLdmRepository() 
            : base("AutomationSQLdmRepository", "/", null, 0, false, "7bd21acd-09e4-4c42-81c5-68b39ccd889b", ".\\RepositoryImages\\AutomationSQLdmRepository7bd21acd.rximgres")
        {
            _iderasqldiagnosticmanagersqldmrepo = new AutomationSQLdmRepositoryFolders.IderaSQLDiagnosticManagerSQLdmRepoAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("7bd21acd-09e4-4c42-81c5-68b39ccd889b")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The IderaSQLDiagnosticManagerSQLdmRepo folder.
        /// </summary>
        [RepositoryFolder("ab074a4b-febe-4253-b4c0-1389e8fcc8ba")]
        public virtual AutomationSQLdmRepositoryFolders.IderaSQLDiagnosticManagerSQLdmRepoAppFolder IderaSQLDiagnosticManagerSQLdmRepo
        {
            get { return _iderasqldiagnosticmanagersqldmrepo; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    public partial class AutomationSQLdmRepositoryFolders
    {
        /// <summary>
        /// The IderaSQLDiagnosticManagerSQLdmRepoAppFolder folder.
        /// </summary>
        [RepositoryFolder("ab074a4b-febe-4253-b4c0-1389e8fcc8ba")]
        public partial class IderaSQLDiagnosticManagerSQLdmRepoAppFolder : RepoGenBaseFolder
        {
            AutomationSQLdmRepositoryFolders.WindowsFormsHostControlFolder _windowsformshostcontrol;

            /// <summary>
            /// Creates a new IderaSQLDiagnosticManagerSQLdmRepo  folder.
            /// </summary>
            public IderaSQLDiagnosticManagerSQLdmRepoAppFolder(RepoGenBaseFolder parentFolder) :
                    base("IderaSQLDiagnosticManagerSQLdmRepo", "/form[@title~'^Idera\\ SQL\\ diagnostic\\ mana']", parentFolder, 30000, null, true, "ab074a4b-febe-4253-b4c0-1389e8fcc8ba", "")
            {
                _windowsformshostcontrol = new AutomationSQLdmRepositoryFolders.WindowsFormsHostControlFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ab074a4b-febe-4253-b4c0-1389e8fcc8ba")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ab074a4b-febe-4253-b4c0-1389e8fcc8ba")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The WindowsFormsHostControl folder.
            /// </summary>
            [RepositoryFolder("897b6ba6-b9a9-497c-a41a-4d5d518409e8")]
            public virtual AutomationSQLdmRepositoryFolders.WindowsFormsHostControlFolder WindowsFormsHostControl
            {
                get { return _windowsformshostcontrol; }
            }
        }

        /// <summary>
        /// The WindowsFormsHostControlFolder folder.
        /// </summary>
        [RepositoryFolder("897b6ba6-b9a9-497c-a41a-4d5d518409e8")]
        public partial class WindowsFormsHostControlFolder : RepoGenBaseFolder
        {
            TableLayoutPanel1InfoClass _tablelayoutpanel1Info;
            TableLayoutPanel2InfoClass _tablelayoutpanel2Info;
            TableLayoutPanelInfoClass _tablelayoutpanelInfo;
            TableLayoutPanel3InfoClass _tablelayoutpanel3Info;

            /// <summary>
            /// Creates a new WindowsFormsHostControl  folder.
            /// </summary>
            public WindowsFormsHostControlFolder(RepoGenBaseFolder parentFolder) :
                    base("WindowsFormsHostControl", "statusbar[@automationid='statusBar']/?/?/container[@automationid='viewContainer']/container[@automationid='viewHost']/container[@automationid='windowsFormsHostControl']", parentFolder, 30000, null, false, "897b6ba6-b9a9-497c-a41a-4d5d518409e8", "")
            {
                _tablelayoutpanel1Info = new TableLayoutPanel1InfoClass(this);
                _tablelayoutpanel2Info = new TableLayoutPanel2InfoClass(this);
                _tablelayoutpanelInfo = new TableLayoutPanelInfoClass(this);
                _tablelayoutpanel3Info = new TableLayoutPanel3InfoClass(this);
            }

            /// <summary>
            /// The TableLayoutPanel1InfoClass folder.
            /// </summary>
            [RepositoryItemInfo("ff8b5a66-0db7-4f5e-a301-2d01c96b8295")]
            public class TableLayoutPanel1InfoClass : RepoItemInfo
            {
                /// <summary>
                /// TableLayoutPanel1InfoClass class constructor.
                /// </summary>
                public TableLayoutPanel1InfoClass(RepoGenBaseFolder parentFolder)
                    : base(parentFolder, "TableLayoutPanel1", ".//container[@controlname='ResourcesCpuView']//container[@controlname='tableLayoutPanel']", 30000, null, "ff8b5a66-0db7-4f5e-a301-2d01c96b8295")
                { }

                /// <summary>
                /// Gets the RESCPU item image.
                /// </summary>
                /// <returns>The RESCPU image.</returns>
                [RepositoryImage("09ee1a75-9323-4310-a384-d73ee606aba9")]
                public CompressedImage GetRESCPU()
                {
                    return GetImage("09ee1a75-9323-4310-a384-d73ee606aba9");
                }

                /// <summary>
                /// Gets the RESCPU item image.
                /// </summary>
                /// <param name="cropRect">The bounds of the sub-image to return.</param>
                /// <returns>The cropped image.</returns>
                [RepositoryImage("09ee1a75-9323-4310-a384-d73ee606aba9")]
                public CompressedImage GetRESCPU(System.Drawing.Rectangle cropRect)
                {
                    return GetImage("09ee1a75-9323-4310-a384-d73ee606aba9", cropRect);
                }
            }

            /// <summary>
            /// The TableLayoutPanel2InfoClass folder.
            /// </summary>
            [RepositoryItemInfo("53ee43ba-7608-4586-9587-cd0e732c0fb8")]
            public class TableLayoutPanel2InfoClass : RepoItemInfo
            {
                /// <summary>
                /// TableLayoutPanel2InfoClass class constructor.
                /// </summary>
                public TableLayoutPanel2InfoClass(RepoGenBaseFolder parentFolder)
                    : base(parentFolder, "TableLayoutPanel2", ".//container[@controlname='ResourcesMemoryView']//container[@controlname='tableLayoutPanel']", 30000, null, "53ee43ba-7608-4586-9587-cd0e732c0fb8")
                { }

                /// <summary>
                /// Gets the RESMemory item image.
                /// </summary>
                /// <returns>The RESMemory image.</returns>
                [RepositoryImage("b21a224c-1f1b-4156-b20e-3087f65664f3")]
                public CompressedImage GetRESMemory()
                {
                    return GetImage("b21a224c-1f1b-4156-b20e-3087f65664f3");
                }

                /// <summary>
                /// Gets the RESMemory item image.
                /// </summary>
                /// <param name="cropRect">The bounds of the sub-image to return.</param>
                /// <returns>The cropped image.</returns>
                [RepositoryImage("b21a224c-1f1b-4156-b20e-3087f65664f3")]
                public CompressedImage GetRESMemory(System.Drawing.Rectangle cropRect)
                {
                    return GetImage("b21a224c-1f1b-4156-b20e-3087f65664f3", cropRect);
                }
            }

            /// <summary>
            /// The TableLayoutPanelInfoClass folder.
            /// </summary>
            [RepositoryItemInfo("3e4e55a7-a240-4a24-9591-0aeb11e77b12")]
            public class TableLayoutPanelInfoClass : RepoItemInfo
            {
                /// <summary>
                /// TableLayoutPanelInfoClass class constructor.
                /// </summary>
                public TableLayoutPanelInfoClass(RepoGenBaseFolder parentFolder)
                    : base(parentFolder, "TableLayoutPanel", ".//container[@controlname='ResourcesSummaryView']//container[@controlname='tableLayoutPanel']", 30000, null, "3e4e55a7-a240-4a24-9591-0aeb11e77b12")
                { }

                /// <summary>
                /// Gets the RESSummary item image.
                /// </summary>
                /// <returns>The RESSummary image.</returns>
                [RepositoryImage("590a2a28-d6aa-429b-a319-3ea66feefca8")]
                public CompressedImage GetRESSummary()
                {
                    return GetImage("590a2a28-d6aa-429b-a319-3ea66feefca8");
                }

                /// <summary>
                /// Gets the RESSummary item image.
                /// </summary>
                /// <param name="cropRect">The bounds of the sub-image to return.</param>
                /// <returns>The cropped image.</returns>
                [RepositoryImage("590a2a28-d6aa-429b-a319-3ea66feefca8")]
                public CompressedImage GetRESSummary(System.Drawing.Rectangle cropRect)
                {
                    return GetImage("590a2a28-d6aa-429b-a319-3ea66feefca8", cropRect);
                }
            }

            /// <summary>
            /// The TableLayoutPanel3InfoClass folder.
            /// </summary>
            [RepositoryItemInfo("a350a986-5335-4bc1-9e3e-4b69e1127749")]
            public class TableLayoutPanel3InfoClass : RepoItemInfo
            {
                /// <summary>
                /// TableLayoutPanel3InfoClass class constructor.
                /// </summary>
                public TableLayoutPanel3InfoClass(RepoGenBaseFolder parentFolder)
                    : base(parentFolder, "TableLayoutPanel3", ".//container[@controlname='ResourcesDiskView']//container[@controlname='tableLayoutPanel']", 30000, null, "a350a986-5335-4bc1-9e3e-4b69e1127749")
                { }

                /// <summary>
                /// Gets the RESDisk item image.
                /// </summary>
                /// <returns>The RESDisk image.</returns>
                [RepositoryImage("c56a9b49-3ad0-4971-93dd-94a62b527b5f")]
                public CompressedImage GetRESDisk()
                {
                    return GetImage("c56a9b49-3ad0-4971-93dd-94a62b527b5f");
                }

                /// <summary>
                /// Gets the RESDisk item image.
                /// </summary>
                /// <param name="cropRect">The bounds of the sub-image to return.</param>
                /// <returns>The cropped image.</returns>
                [RepositoryImage("c56a9b49-3ad0-4971-93dd-94a62b527b5f")]
                public CompressedImage GetRESDisk(System.Drawing.Rectangle cropRect)
                {
                    return GetImage("c56a9b49-3ad0-4971-93dd-94a62b527b5f", cropRect);
                }
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("897b6ba6-b9a9-497c-a41a-4d5d518409e8")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("897b6ba6-b9a9-497c-a41a-4d5d518409e8")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TableLayoutPanel1 item.
            /// </summary>
            [RepositoryItem("ff8b5a66-0db7-4f5e-a301-2d01c96b8295")]
            public virtual Ranorex.Container TableLayoutPanel1
            {
                get
                {
                    return _tablelayoutpanel1Info.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The TableLayoutPanel1 item info.
            /// </summary>
            [RepositoryItemInfo("ff8b5a66-0db7-4f5e-a301-2d01c96b8295")]
            public virtual TableLayoutPanel1InfoClass TableLayoutPanel1Info
            {
                get
                {
                    return _tablelayoutpanel1Info;
                }
            }

            /// <summary>
            /// The TableLayoutPanel2 item.
            /// </summary>
            [RepositoryItem("53ee43ba-7608-4586-9587-cd0e732c0fb8")]
            public virtual Ranorex.Container TableLayoutPanel2
            {
                get
                {
                    return _tablelayoutpanel2Info.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The TableLayoutPanel2 item info.
            /// </summary>
            [RepositoryItemInfo("53ee43ba-7608-4586-9587-cd0e732c0fb8")]
            public virtual TableLayoutPanel2InfoClass TableLayoutPanel2Info
            {
                get
                {
                    return _tablelayoutpanel2Info;
                }
            }

            /// <summary>
            /// The TableLayoutPanel item.
            /// </summary>
            [RepositoryItem("3e4e55a7-a240-4a24-9591-0aeb11e77b12")]
            public virtual Ranorex.Container TableLayoutPanel
            {
                get
                {
                    return _tablelayoutpanelInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The TableLayoutPanel item info.
            /// </summary>
            [RepositoryItemInfo("3e4e55a7-a240-4a24-9591-0aeb11e77b12")]
            public virtual TableLayoutPanelInfoClass TableLayoutPanelInfo
            {
                get
                {
                    return _tablelayoutpanelInfo;
                }
            }

            /// <summary>
            /// The TableLayoutPanel3 item.
            /// </summary>
            [RepositoryItem("a350a986-5335-4bc1-9e3e-4b69e1127749")]
            public virtual Ranorex.Container TableLayoutPanel3
            {
                get
                {
                    return _tablelayoutpanel3Info.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The TableLayoutPanel3 item info.
            /// </summary>
            [RepositoryItemInfo("a350a986-5335-4bc1-9e3e-4b69e1127749")]
            public virtual TableLayoutPanel3InfoClass TableLayoutPanel3Info
            {
                get
                {
                    return _tablelayoutpanel3Info;
                }
            }
        }

    }
#pragma warning restore 0436
}