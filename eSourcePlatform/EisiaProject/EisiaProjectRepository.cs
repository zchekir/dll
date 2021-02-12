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

namespace EisiaProject
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the EisiaProjectRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
    [RepositoryFolder("7e4fcf03-52d7-400f-bf8b-1d8af0398b10")]
    public partial class EisiaProjectRepository : RepoGenBaseFolder
    {
        static EisiaProjectRepository instance = new EisiaProjectRepository();

        /// <summary>
        /// Gets the singleton class instance representing the EisiaProjectRepository element repository.
        /// </summary>
        [RepositoryFolder("7e4fcf03-52d7-400f-bf8b-1d8af0398b10")]
        public static EisiaProjectRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public EisiaProjectRepository() 
            : base("EisiaProjectRepository", "/", null, 0, false, "7e4fcf03-52d7-400f-bf8b-1d8af0398b10", ".\\RepositoryImages\\EisiaProjectRepository7e4fcf03.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("7e4fcf03-52d7-400f-bf8b-1d8af0398b10")]
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
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
    public partial class EisiaProjectRepositoryFolders
    {
    }
#pragma warning restore 0436
}