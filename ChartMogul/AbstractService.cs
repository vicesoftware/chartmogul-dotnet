﻿using ChartMogul.API;

abstract public class AbstractService
{
    protected Http Http;

    protected AbstractService(Http http)
    {
        this.Http = http;
    }
}
