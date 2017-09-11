using System;
using System.Net;
using Moq;
using Xunit;

namespace RestDotNet.Tests.Fluent
{
    public class NotFoundTests : FluentBaseTests
    {
        [Fact]
        public override void Typed_Response_With_Content_Register_Callback()
        {
            TypedMock.Object.NotFound((object res) => { });
            TypedMock.Verify(handler => handler.RegisterCallback(HttpStatusCode.NotFound, It.IsAny<Action<object>>()), Times.Once);
        }

        [Fact]
        public override void Typed_Response_With_Content_Return_The_Same()
        {
            IRestRequest<object> act = TypedMock.Object.NotFound((object res) => { });
            Assert.Equal(TypedMock.Object, act);
        }

        [Fact]
        public override void Typed_Response_Without_Content_Register_Callback()
        {
            TypedMock.Object.NotFound(() => { });
            TypedMock.Verify(handler => handler.RegisterCallback(HttpStatusCode.NotFound, It.IsAny<Action>()), Times.Once);
        }

        [Fact]
        public override void Typed_Response_Without_Content_Return_The_Same()
        {
            IRestRequest<object> act = TypedMock.Object.NotFound(() => { });
            Assert.Equal(TypedMock.Object, act);
        }

        [Fact]
        public override void Untyped_Response_With_Content_Register_Callback()
        {
            UntypedMock.Object.NotFound((object res) => { });
            UntypedMock.Verify(handler => handler.RegisterCallback(HttpStatusCode.NotFound, It.IsAny<Action<object>>()), Times.Once);
        }

        [Fact]
        public override void Untyped_Response_With_Content_Return_The_Same()
        {
            IRestRequest act = UntypedMock.Object.NotFound((object res) => { });
            Assert.Equal(UntypedMock.Object, act);
        }

        [Fact]
        public override void Untyped_Response_Without_Content_Register_Callback()
        {
            UntypedMock.Object.NotFound(() => { });
            UntypedMock.Verify(handler => handler.RegisterCallback(HttpStatusCode.NotFound, It.IsAny<Action>()), Times.Once);
        }

        [Fact]
        public override void Untyped_Response_Without_Content_Return_The_Same()
        {
            IRestRequest act = UntypedMock.Object.NotFound(() => { });
            Assert.Equal(UntypedMock.Object, act);
        }
    }
}