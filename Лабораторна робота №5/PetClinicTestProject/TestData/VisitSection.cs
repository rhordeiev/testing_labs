using Microsoft.Extensions.Configuration;

public class VisitSection {
    public VisitConfiguration visit { get; }

    public VisitSection(IConfiguration configuration){
        configuration.GetSection("visit").Bind(visit = new VisitConfiguration());
    }
}