﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MakeItSoLib
{
    /// <summary>
    /// Holds information parsed from one configuration (Debug, Release etc)
    /// in a C# project.
    /// </summary>
    public class ProjectConfigurationInfo_CSharp
    {
        #region Public methods and properties

        /// <summary>
        /// The project that holds this configuration.
        /// </summary>
        public ProjectInfo_CSharp ParentProjectInfo
        {
            get { return m_parentProjectInfo; }
            set { m_parentProjectInfo = value; }
        }

        /// <summary>
        /// The configuration's name.
        /// Note that we strip out any spaces in the configuration name.
        /// </summary>
        public string Name
        {
            get { return m_name; }
            set { m_name = value.Replace(" ", ""); }
        }

        /// <summary>
        /// Gets or sets whether to generate optimized code or not.
        /// </summary>
        public bool Optimize
        {
            get { return m_optimize; }
            set { m_optimize = value; }
        }

        /// <summary>
        /// Gets or sets the output folder, relative to the project's root folder.
        /// </summary>
        public string OutputFolder
        {
            get { return m_outputFolder; }
            set { m_outputFolder = value.Replace(" ", ""); }
        }

        /// <summary>
        /// Gets or sets whether we treat warnings as errors.
        /// </summary>
        public bool ThreatWarningsAsErrors
        {
            get { return m_treatWarningsAsErrors; }
            set { m_treatWarningsAsErrors = value; }
        }

        /// <summary>
        /// Adds a defined constant, e.g. DEBUG, TRACE.
        /// </summary>
        public void addDefinedConstant(string definedConstant)
        {
            m_definedConstants.Add(definedConstant);
        }

        /// <summary>
        /// Gets the collection of defined constants (DEBUG, TRACE etc)
        /// </summary>
        public List<string> getDefinedConstants()
        {
            return m_definedConstants.ToList();
        }

        /// <summary>
        /// Gets or sets whether we generate debug symbols.
        /// </summary>
        public bool Debug
        {
            get { return m_debug; }
            set { m_debug = value; }
        }

        #endregion

        #region Private data

        // The configuration name...
        private string m_name = "";

        // Whether to generate optimized code or not...
        private bool m_optimize = false;

        // The output folder for built objects such as libraries and executables...
        private string m_outputFolder = "";

        // Treat warnings as errors...
        private bool m_treatWarningsAsErrors = false;

        // The collection of defined constants, e.g. DEGIG, TRACE...
        private HashSet<string> m_definedConstants = new HashSet<string>();

        // Whether we generate debug symbols...
        private bool m_debug = false;

        // The parent project...
        private ProjectInfo_CSharp m_parentProjectInfo = null;

        #endregion
    }
}