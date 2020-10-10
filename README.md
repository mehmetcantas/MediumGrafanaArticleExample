# MediumGrafanaArticleExample
Projeyi çalıştırmadan önce bilgisayarınızda Docker yüklü olduğundan emin olunuz. Ardından aşağıdaki komutları terminal ya da powershell üzerinden çalıştırarak gerekli kurulumları yapmanız gerekiyor.

test readme changes

test readme changes - 1 
test readme changes - 2
test readme changes - 3

```
docker run -d --name=docker_grafana -p 3000:3000 grafana/grafana
docker run -d --name=docker_influxdb -p 8086:8086 -v /docker-volumes/influxdb:/var/lib/influxdb influxdb
```
