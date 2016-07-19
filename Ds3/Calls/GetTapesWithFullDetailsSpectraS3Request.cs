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
    public class GetTapesWithFullDetailsSpectraS3Request : Ds3Request
    {
        
        
        private bool? _assignedToStorageDomain;
        public bool? AssignedToStorageDomain
        {
            get { return _assignedToStorageDomain; }
            set { WithAssignedToStorageDomain(value); }
        }

        private string _barCode;
        public string BarCode
        {
            get { return _barCode; }
            set { WithBarCode(value); }
        }

        private string _bucketId;
        public string BucketId
        {
            get { return _bucketId; }
            set { WithBucketId(value); }
        }

        private string _ejectLabel;
        public string EjectLabel
        {
            get { return _ejectLabel; }
            set { WithEjectLabel(value); }
        }

        private string _ejectLocation;
        public string EjectLocation
        {
            get { return _ejectLocation; }
            set { WithEjectLocation(value); }
        }

        private bool? _fullOfData;
        public bool? FullOfData
        {
            get { return _fullOfData; }
            set { WithFullOfData(value); }
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

        private string _partitionId;
        public string PartitionId
        {
            get { return _partitionId; }
            set { WithPartitionId(value); }
        }

        private TapeState? _previousState;
        public TapeState? PreviousState
        {
            get { return _previousState; }
            set { WithPreviousState(value); }
        }

        private string _serialNumber;
        public string SerialNumber
        {
            get { return _serialNumber; }
            set { WithSerialNumber(value); }
        }

        private TapeState? _state;
        public TapeState? State
        {
            get { return _state; }
            set { WithState(value); }
        }

        private string _storageDomainId;
        public string StorageDomainId
        {
            get { return _storageDomainId; }
            set { WithStorageDomainId(value); }
        }

        private TapeType? _type;
        public TapeType? Type
        {
            get { return _type; }
            set { WithType(value); }
        }

        private bool? _writeProtected;
        public bool? WriteProtected
        {
            get { return _writeProtected; }
            set { WithWriteProtected(value); }
        }

        public GetTapesWithFullDetailsSpectraS3Request WithAssignedToStorageDomain(bool? assignedToStorageDomain)
        {
            this._assignedToStorageDomain = assignedToStorageDomain;
            if (assignedToStorageDomain != null)
            {
                this.QueryParams.Add("assigned_to_storage_domain", assignedToStorageDomain.ToString());
            }
            else
            {
                this.QueryParams.Remove("assigned_to_storage_domain");
            }
            return this;
        }
        public GetTapesWithFullDetailsSpectraS3Request WithBarCode(string barCode)
        {
            this._barCode = barCode;
            if (barCode != null)
            {
                this.QueryParams.Add("bar_code", barCode);
            }
            else
            {
                this.QueryParams.Remove("bar_code");
            }
            return this;
        }
        public GetTapesWithFullDetailsSpectraS3Request WithBucketId(Guid? bucketId)
        {
            this._bucketId = bucketId.ToString();
            if (bucketId != null)
            {
                this.QueryParams.Add("bucket_id", bucketId.ToString());
            }
            else
            {
                this.QueryParams.Remove("bucket_id");
            }
            return this;
        }
        public GetTapesWithFullDetailsSpectraS3Request WithBucketId(string bucketId)
        {
            this._bucketId = bucketId;
            if (bucketId != null)
            {
                this.QueryParams.Add("bucket_id", bucketId);
            }
            else
            {
                this.QueryParams.Remove("bucket_id");
            }
            return this;
        }
        public GetTapesWithFullDetailsSpectraS3Request WithEjectLabel(string ejectLabel)
        {
            this._ejectLabel = ejectLabel;
            if (ejectLabel != null)
            {
                this.QueryParams.Add("eject_label", ejectLabel);
            }
            else
            {
                this.QueryParams.Remove("eject_label");
            }
            return this;
        }
        public GetTapesWithFullDetailsSpectraS3Request WithEjectLocation(string ejectLocation)
        {
            this._ejectLocation = ejectLocation;
            if (ejectLocation != null)
            {
                this.QueryParams.Add("eject_location", ejectLocation);
            }
            else
            {
                this.QueryParams.Remove("eject_location");
            }
            return this;
        }
        public GetTapesWithFullDetailsSpectraS3Request WithFullOfData(bool? fullOfData)
        {
            this._fullOfData = fullOfData;
            if (fullOfData != null)
            {
                this.QueryParams.Add("full_of_data", fullOfData.ToString());
            }
            else
            {
                this.QueryParams.Remove("full_of_data");
            }
            return this;
        }
        public GetTapesWithFullDetailsSpectraS3Request WithLastPage(bool? lastPage)
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
        public GetTapesWithFullDetailsSpectraS3Request WithPageLength(int? pageLength)
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
        public GetTapesWithFullDetailsSpectraS3Request WithPageOffset(int? pageOffset)
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
        public GetTapesWithFullDetailsSpectraS3Request WithPageStartMarker(Guid? pageStartMarker)
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
        public GetTapesWithFullDetailsSpectraS3Request WithPageStartMarker(string pageStartMarker)
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
        public GetTapesWithFullDetailsSpectraS3Request WithPartitionId(Guid? partitionId)
        {
            this._partitionId = partitionId.ToString();
            if (partitionId != null)
            {
                this.QueryParams.Add("partition_id", partitionId.ToString());
            }
            else
            {
                this.QueryParams.Remove("partition_id");
            }
            return this;
        }
        public GetTapesWithFullDetailsSpectraS3Request WithPartitionId(string partitionId)
        {
            this._partitionId = partitionId;
            if (partitionId != null)
            {
                this.QueryParams.Add("partition_id", partitionId);
            }
            else
            {
                this.QueryParams.Remove("partition_id");
            }
            return this;
        }
        public GetTapesWithFullDetailsSpectraS3Request WithPreviousState(TapeState? previousState)
        {
            this._previousState = previousState;
            if (previousState != null)
            {
                this.QueryParams.Add("previous_state", previousState.ToString());
            }
            else
            {
                this.QueryParams.Remove("previous_state");
            }
            return this;
        }
        public GetTapesWithFullDetailsSpectraS3Request WithSerialNumber(string serialNumber)
        {
            this._serialNumber = serialNumber;
            if (serialNumber != null)
            {
                this.QueryParams.Add("serial_number", serialNumber);
            }
            else
            {
                this.QueryParams.Remove("serial_number");
            }
            return this;
        }
        public GetTapesWithFullDetailsSpectraS3Request WithState(TapeState? state)
        {
            this._state = state;
            if (state != null)
            {
                this.QueryParams.Add("state", state.ToString());
            }
            else
            {
                this.QueryParams.Remove("state");
            }
            return this;
        }
        public GetTapesWithFullDetailsSpectraS3Request WithStorageDomainId(Guid? storageDomainId)
        {
            this._storageDomainId = storageDomainId.ToString();
            if (storageDomainId != null)
            {
                this.QueryParams.Add("storage_domain_id", storageDomainId.ToString());
            }
            else
            {
                this.QueryParams.Remove("storage_domain_id");
            }
            return this;
        }
        public GetTapesWithFullDetailsSpectraS3Request WithStorageDomainId(string storageDomainId)
        {
            this._storageDomainId = storageDomainId;
            if (storageDomainId != null)
            {
                this.QueryParams.Add("storage_domain_id", storageDomainId);
            }
            else
            {
                this.QueryParams.Remove("storage_domain_id");
            }
            return this;
        }
        public GetTapesWithFullDetailsSpectraS3Request WithType(TapeType? type)
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
        public GetTapesWithFullDetailsSpectraS3Request WithWriteProtected(bool? writeProtected)
        {
            this._writeProtected = writeProtected;
            if (writeProtected != null)
            {
                this.QueryParams.Add("write_protected", writeProtected.ToString());
            }
            else
            {
                this.QueryParams.Remove("write_protected");
            }
            return this;
        }

        
        public GetTapesWithFullDetailsSpectraS3Request()
        {
            
            this.QueryParams.Add("full_details", null);

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
                return "/_rest_/tape";
            }
        }
    }
}