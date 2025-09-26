using System;

namespace MareSynchronos.API.Dto.P2P
{
    public enum RtcSignalType
    {
        Offer,
        Answer,
        IceCandidate
    }

    public class RtcOfferDto
    {
        public string TargetUID { get; set; } = string.Empty;
        public string Sdp { get; set; } = string.Empty;
    }

    public class RtcAnswerDto
    {
        public string TargetUID { get; set; } = string.Empty;
        public string Sdp { get; set; } = string.Empty;
    }

    public class RtcIceCandidateDto
    {
        public string TargetUID { get; set; } = string.Empty;
        public string Candidate { get; set; } = string.Empty;
        public string? SdpMid { get; set; }
        public int? SdpMLineIndex { get; set; }
    }
}
