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

namespace PlatformAdmin
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the PlatformAdminRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    [RepositoryFolder("b4eff84f-6707-45e6-a699-b79e556d43d1")]
    public partial class PlatformAdminRepository : RepoGenBaseFolder
    {
        static PlatformAdminRepository instance = new PlatformAdminRepository();

        /// <summary>
        /// Gets the singleton class instance representing the PlatformAdminRepository element repository.
        /// </summary>
        [RepositoryFolder("b4eff84f-6707-45e6-a699-b79e556d43d1")]
        public static PlatformAdminRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public PlatformAdminRepository() 
            : base("PlatformAdminRepository", "/", null, 0, false, "b4eff84f-6707-45e6-a699-b79e556d43d1", ".\\RepositoryImages\\PlatformAdminRepositoryb4eff84f.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("b4eff84f-6707-45e6-a699-b79e556d43d1")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    public partial class PlatformAdminRepositoryFolders
    {
    }
#pragma warning restore 0436
}