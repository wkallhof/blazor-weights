aws --version

aws s3 sync ./src/www/ s3://%S3_BUCKET%/ --acl public-read --delete --content-type text/html --exclude "assets*"

aws s3 sync ./src/www/assets s3://%S3_BUCKET%/assets/ --acl public-read --delete --follow-symlinks