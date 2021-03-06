/*
 * ******************************************************************************
 *   Copyright 2014-2016 Spectra Logic Corporation. All Rights Reserved.
 *   Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *   this file except in compliance with the License. A copy of the License is located at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 *   or in the "license" file accompanying this file.
 *   This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *   CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *   specific language governing permissions and limitations under the License.
 * ****************************************************************************
 */

// This code is auto-generated, do not modify
using Ds3.Models;
using System;
using System.Net;

namespace Ds3.Calls
{
    public class GetTapeFailuresSpectraS3Request : Ds3Request
    {
        
        
        private string _errorMessage;
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { WithErrorMessage(value); }
        }

        private bool? _lastPage;
        public bool? LastPage
        {
            get { return _lastPage; }
            set { WithLastPage(value); }
        }

        private int? _pageLength;
        public int? PageLength
        {
            get { return _pageLength; }
            set { WithPageLength(value); }
        }

        private int? _pageOffset;
        public int? PageOffset
        {
            get { return _pageOffset; }
            set { WithPageOffset(value); }
        }

        private string _pageStartMarker;
        public string PageStartMarker
        {
            get { return _pageStartMarker; }
            set { WithPageStartMarker(value); }
        }

        private string _tapeDriveId;
        public string TapeDriveId
        {
            get { return _tapeDriveId; }
            set { WithTapeDriveId(value); }
        }

        private string _tapeId;
        public string TapeId
        {
            get { return _tapeId; }
            set { WithTapeId(value); }
        }

        private TapeFailureType? _type;
        public TapeFailureType? Type
        {
            get { return _type; }
            set { WithType(value); }
        }

        public GetTapeFailuresSpectraS3Request WithErrorMessage(string errorMessage)
        {
            this._errorMessage = errorMessage;
            if (errorMessage != null)
            {
                this.QueryParams.Add("error_message", errorMessage);
            }
            else
            {
                this.QueryParams.Remove("error_message");
            }
            return this;
        }
        public GetTapeFailuresSpectraS3Request WithLastPage(bool? lastPage)
        {
            this._lastPage = lastPage;
            if (lastPage != null)
            {
                this.QueryParams.Add("last_page", lastPage.ToString());
            }
            else
            {
                this.QueryParams.Remove("last_page");
            }
            return this;
        }
        public GetTapeFailuresSpectraS3Request WithPageLength(int? pageLength)
        {
            this._pageLength = pageLength;
            if (pageLength != null)
            {
                this.QueryParams.Add("page_length", pageLength.ToString());
            }
            else
            {
                this.QueryParams.Remove("page_length");
            }
            return this;
        }
        public GetTapeFailuresSpectraS3Request WithPageOffset(int? pageOffset)
        {
            this._pageOffset = pageOffset;
            if (pageOffset != null)
            {
                this.QueryParams.Add("page_offset", pageOffset.ToString());
            }
            else
            {
                this.QueryParams.Remove("page_offset");
            }
            return this;
        }
        public GetTapeFailuresSpectraS3Request WithPageStartMarker(Guid? pageStartMarker)
        {
            this._pageStartMarker = pageStartMarker.ToString();
            if (pageStartMarker != null)
            {
                this.QueryParams.Add("page_start_marker", pageStartMarker.ToString());
            }
            else
            {
                this.QueryParams.Remove("page_start_marker");
            }
            return this;
        }
        public GetTapeFailuresSpectraS3Request WithPageStartMarker(string pageStartMarker)
        {
            this._pageStartMarker = pageStartMarker;
            if (pageStartMarker != null)
            {
                this.QueryParams.Add("page_start_marker", pageStartMarker);
            }
            else
            {
                this.QueryParams.Remove("page_start_marker");
            }
            return this;
        }
        public GetTapeFailuresSpectraS3Request WithTapeDriveId(Guid? tapeDriveId)
        {
            this._tapeDriveId = tapeDriveId.ToString();
            if (tapeDriveId != null)
            {
                this.QueryParams.Add("tape_drive_id", tapeDriveId.ToString());
            }
            else
            {
                this.QueryParams.Remove("tape_drive_id");
            }
            return this;
        }
        public GetTapeFailuresSpectraS3Request WithTapeDriveId(string tapeDriveId)
        {
            this._tapeDriveId = tapeDriveId;
            if (tapeDriveId != null)
            {
                this.QueryParams.Add("tape_drive_id", tapeDriveId);
            }
            else
            {
                this.QueryParams.Remove("tape_drive_id");
            }
            return this;
        }
        public GetTapeFailuresSpectraS3Request WithTapeId(Guid? tapeId)
        {
            this._tapeId = tapeId.ToString();
            if (tapeId != null)
            {
                this.QueryParams.Add("tape_id", tapeId.ToString());
            }
            else
            {
                this.QueryParams.Remove("tape_id");
            }
            return this;
        }
        public GetTapeFailuresSpectraS3Request WithTapeId(string tapeId)
        {
            this._tapeId = tapeId;
            if (tapeId != null)
            {
                this.QueryParams.Add("tape_id", tapeId);
            }
            else
            {
                this.QueryParams.Remove("tape_id");
            }
            return this;
        }
        public GetTapeFailuresSpectraS3Request WithType(TapeFailureType? type)
        {
            this._type = type;
            if (type != null)
            {
                this.QueryParams.Add("type", type.ToString());
            }
            else
            {
                this.QueryParams.Remove("type");
            }
            return this;
        }

        
        public GetTapeFailuresSpectraS3Request()
        {
            
        }

        internal override HttpVerb Verb
        {
            get
            {
                return HttpVerb.GET;
            }
        }

        internal override string Path
        {
            get
            {
                return "/_rest_/tape_failure";
            }
        }
    }
}