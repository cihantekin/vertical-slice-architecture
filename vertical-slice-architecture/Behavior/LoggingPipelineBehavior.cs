using MediatR;

namespace vertical_slice_architecture.Behavior
{
    public class LoggingPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : class
    {
        private readonly ILogger<LoggingPipelineBehavior<TRequest, TResponse>> _logger;

        public LoggingPipelineBehavior(ILogger<LoggingPipelineBehavior<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Request started {typeof(TRequest).Name}, {DateTime.UtcNow}");

            var result = await next();

            _logger.LogInformation($"Request completed {typeof(TRequest).Name}, {DateTime.UtcNow}");

            return result;
        }
    }
}
