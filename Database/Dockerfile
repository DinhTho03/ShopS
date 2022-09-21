FROM mcr.microsoft.com/mssql/server:2022-latest

ENV SA_PASSWORD AVeryStrongPassword196
ENV ACCEPT_EULA Y
ENV MSSQL_PID Developer

WORKDIR /db
USER root
COPY . .

RUN chmod +x /db/run-initialization.sh

EXPOSE 1433

CMD /bin/bash /db/entrypoint.sh
