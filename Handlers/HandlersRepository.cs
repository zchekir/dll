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

namespace Handlers
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the HandlersRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    [RepositoryFolder("e424e85c-cb63-4de2-8655-61b5d9c54236")]
    public partial class HandlersRepository : RepoGenBaseFolder
    {
        static HandlersRepository instance = new HandlersRepository();

        /// <summary>
        /// Gets the singleton class instance representing the HandlersRepository element repository.
        /// </summary>
        [RepositoryFolder("e424e85c-cb63-4de2-8655-61b5d9c54236")]
        public static HandlersRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public HandlersRepository() 
            : base("HandlersRepository", "/", null, 0, false, "e424e85c-cb63-4de2-8655-61b5d9c54236", ".\\RepositoryImages\\HandlersRepositorye424e85c.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("e424e85c-cb63-4de2-8655-61b5d9c54236")]
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
    public partial class HandlersRepositoryFolders
    {
    }
#pragma warning restore 0436
}