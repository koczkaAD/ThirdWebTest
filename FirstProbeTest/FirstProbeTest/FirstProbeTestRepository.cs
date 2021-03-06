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

namespace FirstProbeTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the FirstProbeTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
    [RepositoryFolder("2a497b67-c760-4482-bc70-bdb1fd6bc0a2")]
    public partial class FirstProbeTestRepository : RepoGenBaseFolder
    {
        static FirstProbeTestRepository instance = new FirstProbeTestRepository();
        FirstProbeTestRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;

        /// <summary>
        /// Gets the singleton class instance representing the FirstProbeTestRepository element repository.
        /// </summary>
        [RepositoryFolder("2a497b67-c760-4482-bc70-bdb1fd6bc0a2")]
        public static FirstProbeTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public FirstProbeTestRepository() 
            : base("FirstProbeTestRepository", "/", null, 0, false, "2a497b67-c760-4482-bc70-bdb1fd6bc0a2", ".\\RepositoryImages\\FirstProbeTestRepository2a497b67.rximgres")
        {
            _applicationundertest = new FirstProbeTestRepositoryFolders.ApplicationUnderTestAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("2a497b67-c760-4482-bc70-bdb1fd6bc0a2")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("3417fcca-48a7-492b-a819-691f4ca56ddb")]
        public virtual FirstProbeTestRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
    public partial class FirstProbeTestRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("3417fcca-48a7-492b-a819-691f4ca56ddb")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _testemailInfo;
            RepoItemInfo _testcheckboxInfo;
            RepoItemInfo _blueInfo;
            RepoItemInfo _submitInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, true, "3417fcca-48a7-492b-a819-691f4ca56ddb", "")
            {
                _testemailInfo = new RepoItemInfo(this, "Testemail", ".//input[#'testemail']", 30000, null, "94daff6f-ff01-45e4-b539-ddedc85cc6c2");
                _testcheckboxInfo = new RepoItemInfo(this, "Testcheckbox", ".//input[#'testcheckbox']", 30000, null, "608a6fee-e7aa-42e1-ad8f-3b2dbc00bf00");
                _blueInfo = new RepoItemInfo(this, "Blue", ".//select[#'testmultiple']/option[@value='blue']", 30000, null, "3bc83d7f-f744-442e-9573-a8ff3b3ab4ce");
                _submitInfo = new RepoItemInfo(this, "Submit", ".//input[#'submit']", 30000, null, "44f536df-f0ff-4225-85b1-0d57362a3be8");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("3417fcca-48a7-492b-a819-691f4ca56ddb")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("3417fcca-48a7-492b-a819-691f4ca56ddb")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Testemail item.
            /// </summary>
            [RepositoryItem("94daff6f-ff01-45e4-b539-ddedc85cc6c2")]
            public virtual Ranorex.InputTag Testemail
            {
                get
                {
                    return _testemailInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Testemail item info.
            /// </summary>
            [RepositoryItemInfo("94daff6f-ff01-45e4-b539-ddedc85cc6c2")]
            public virtual RepoItemInfo TestemailInfo
            {
                get
                {
                    return _testemailInfo;
                }
            }

            /// <summary>
            /// The Testcheckbox item.
            /// </summary>
            [RepositoryItem("608a6fee-e7aa-42e1-ad8f-3b2dbc00bf00")]
            public virtual Ranorex.InputTag Testcheckbox
            {
                get
                {
                    return _testcheckboxInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Testcheckbox item info.
            /// </summary>
            [RepositoryItemInfo("608a6fee-e7aa-42e1-ad8f-3b2dbc00bf00")]
            public virtual RepoItemInfo TestcheckboxInfo
            {
                get
                {
                    return _testcheckboxInfo;
                }
            }

            /// <summary>
            /// The Blue item.
            /// </summary>
            [RepositoryItem("3bc83d7f-f744-442e-9573-a8ff3b3ab4ce")]
            public virtual Ranorex.OptionTag Blue
            {
                get
                {
                    return _blueInfo.CreateAdapter<Ranorex.OptionTag>(true);
                }
            }

            /// <summary>
            /// The Blue item info.
            /// </summary>
            [RepositoryItemInfo("3bc83d7f-f744-442e-9573-a8ff3b3ab4ce")]
            public virtual RepoItemInfo BlueInfo
            {
                get
                {
                    return _blueInfo;
                }
            }

            /// <summary>
            /// The Submit item.
            /// </summary>
            [RepositoryItem("44f536df-f0ff-4225-85b1-0d57362a3be8")]
            public virtual Ranorex.InputTag Submit
            {
                get
                {
                    return _submitInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Submit item info.
            /// </summary>
            [RepositoryItemInfo("44f536df-f0ff-4225-85b1-0d57362a3be8")]
            public virtual RepoItemInfo SubmitInfo
            {
                get
                {
                    return _submitInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}