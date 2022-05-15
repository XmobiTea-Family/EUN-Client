namespace XmobiTea.EUN.Entity.Response
{
    using XmobiTea.EUN.Common;

    public class ChangeGameObjectRoomOperationResponse : CustomOperationResponse
    {
        public bool Success { get; private set; }

        public ChangeGameObjectRoomOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!HasError)
            {
                Success = true;
            }
        }
    }
}
