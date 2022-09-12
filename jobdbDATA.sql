﻿/****** Script for SelectTopNRows command from SSMS  ******/
use jobdb
go
INSERT INTO [jobdb].[jobs_category]
           ([active]
           ,[created_date]
           ,[updated_date]
           ,[name])
     VALUES (1,'2022-03-27 03:07:09.645266','2022-03-27 03:07:09.645266','Bán hàng - Tiếp thị'),(1,'2022-03-27 03:07:16.265534','2022-03-27 03:07:16.265534','Dịch vụ'),
	 (1,'2022-03-27 03:07:22.674430','2022-03-27 03:07:22.674430','Chăm sóc sức khỏe'),
	 (1,'2022-03-27 03:07:28.117763','2022-03-27 03:07:28.117763','Sản xuất'),
	 (1,'2022-03-27 03:07:36.332880','2022-03-27 03:07:36.332880','Hàng tiêu dùng'),
	 (1,'2022-03-27 03:07:47.462350','2022-03-27 03:07:47.462350','Máy tính - Công nghệ thông tin'),
	 (1,'2022-03-27 03:07:59.212580','2022-03-27 03:07:59.212580','Hành chính - Nhân sự'),
	 (1,'2022-03-27 03:08:07.861653','2022-03-27 03:08:07.861653','Kế toán - Tài chính'),
	 (1,'2022-03-27 03:08:16.612478','2022-03-27 03:08:16.612478','Truyền thông MEDIA'),
	 (1,'2022-03-27 03:08:20.688285','2022-03-27 03:08:20.688285','Xây dựng'),
	 (1,'2022-03-27 03:08:25.183364','2022-03-27 03:08:25.183364','Kỹ thuật'),
	 (1,'2022-03-27 03:08:32.187541','2022-03-27 03:08:32.187541','Giáo dục - Đào tạo'),
	 (1,'2022-03-27 03:08:43.799988','2022-03-27 03:08:43.799988','Khoa học'),
	 (1,'2022-03-27 03:08:50.605483','2022-03-27 03:08:50.605483','Khách sạn - Du lịch');
INSERT INTO [jobdb].[jobs_major]
           ([active]
           ,[created_date]
           ,[updated_date]
           ,[name]
           ,[description]
           ,[category_id])
     VALUES (1,'2022-03-27 03:09:27.250036','2022-03-27 03:09:27.250036','Tiếp thị - Marketing','Bán hàng tiếp thị',1),
	 (1,'2022-03-27 03:09:39.466295','2022-03-27 03:09:39.466295','Tiếp thị trực tuyến','Bán hàng tiếp thị',1),
	 (1,'2022-03-27 03:09:54.355608','2022-03-27 03:09:54.355608','Bán lẻ sỉ','Bán hàng tiếp thị',1),
	 (1,'2022-03-27 03:10:05.205213','2022-03-27 03:10:05.205213','Bán hàng - Kinh doanh','Bán hàng tiếp thị',1),
	 (1,'2022-03-27 03:10:18.200192','2022-03-27 03:10:18.200192','Tư vấn','việc làm dịch vụ',2),
	 (1,'2022-03-27 03:10:26.610393','2022-03-27 03:10:26.610393','An ninh - Bảo vệ','việc làm dịch vụ',2),
	 (1,'2022-03-27 03:10:36.073880','2022-03-27 03:10:36.073880','Luật - Pháp lý','việc làm dịch vụ',2),
	 (1,'2022-03-27 03:10:47.091561','2022-03-27 03:10:47.091561','Dịch vụ khách hàng','việc làm dịch vụ',2),
	 (1,'2022-03-27 03:10:58.108611','2022-03-27 03:10:58.108611','Lao động phổ thông','việc làm dịch vụ',2),
	 (1,'2022-03-27 03:11:05.730716','2022-03-27 03:11:05.730716','Bưu chính viễn thông','việc làm dịch vụ',2),
	 (1,'2022-03-27 03:11:20.026122','2022-03-27 03:11:20.026122','Vận chuyển - Giao nhận - Kho vận','việc làm dịch vụ',2),
	 (1,'2022-03-27 03:11:40.440263','2022-03-27 03:11:40.440263','Phi chính phủ - Phi lợi nhuận','việc làm dịch vụ từ thiện',2),
	 (1,'2022-03-27 03:12:25.514399','2022-03-27 03:12:25.514399','Y tế','Việc làm chăm sóc sức khỏe',3),
	 (1,'2022-03-27 03:12:39.090159','2022-03-27 03:12:39.090159','Dược phẩm','Việc làm chăm sóc sức khỏe',3),
	 (1,'2022-03-27 03:13:01.066737','2022-03-27 03:13:01.066737','Dệt may - Da giày - Thời trang','Việc làm sản xuất',4),
	 (1,'2022-03-27 03:13:16.142169','2022-03-27 03:13:16.142169','Quản lý chất lượng (QA/QC)','Việc làm sản xuất',4),
	 (1,'2022-03-27 03:13:28.090597','2022-03-27 03:13:28.090597','Thu mua - Vật tư','Việc làm sản xuất',4),
	 (1,'2022-03-27 03:13:37.312776','2022-03-27 03:13:37.312776','An toàn lao động','Việc làm sản xuất',4),
	 (1,'2022-03-27 03:13:51.474249','2022-03-27 03:13:51.474249','Sản xuất - Vận hành sản xuất','Việc làm sản xuất',4),
	 (1,'2022-03-27 03:14:00.064121','2022-03-27 03:14:00.064121','Xuất nhập khẩu','Việc làm sản xuất',4),
	 (1,'2022-03-27 03:14:07.866496','2022-03-27 03:14:07.866496','Đồ gỗ','Việc làm sản xuất',4),
	 (1,'2022-03-27 03:14:17.635181','2022-03-27 03:14:17.635181','In ấn - Xuất bản','Việc làm sản xuất',4),
	 (1,'2022-03-27 03:14:52.383763','2022-03-27 03:14:52.383763','Hàng gia dụng - Chăm sóc cá nhân','Việc làm thuộc hàng tiêu dùng',5),
	 (1,'2022-03-27 03:15:09.184034','2022-03-27 03:15:09.184034','Thực phẩm và đồ uống','Việc làm thuộc hàng tiêu dùng',5),
	 (1,'2022-03-27 03:15:31.139073','2022-03-27 03:15:31.139073','CNTT - Phần mềm','Việc làm máy tính và công nghệ thông tin',6),
	 (1,'2022-03-27 03:15:58.955999','2022-03-27 03:15:58.955999','CNTT - Phần cứng - Mạng','Việc làm máy tính và công nghệ thông tin',6),
	 (1,'2022-03-27 03:17:58.970005','2022-03-27 03:17:58.970005','Nhân sự','Việc làm hành chính nhân sự',7),
	 (1,'2022-03-27 03:18:09.956989','2022-03-27 03:18:09.956989','Hành chính - Thư ký','Việc làm hành chính nhân sự',7),
	 (1,'2022-03-27 03:18:19.752341','2022-03-27 03:18:19.752341','Biên phiên dịch','Việc làm hành chính nhân sự',7),
	 (1,'2022-03-27 03:18:43.169769','2022-03-27 03:18:43.169769','Ngân hàng','Việc làm kế toán tài chính',8),
	 (1,'2022-03-27 03:18:52.024533','2022-03-27 03:18:52.024533','Chứng khoán','Việc làm kế toán tài chính',8),
	 (1,'2022-03-27 03:19:03.809655','2022-03-27 03:19:03.809655','Bảo hiểm','Việc làm kế toán tài chính',8),
	 (1,'2022-03-27 03:19:15.339864','2022-03-27 03:19:15.339864','Tài chính - Đầu tư','Việc làm kế toán tài chính',8),
	 (1,'2022-03-27 03:19:24.947691','2022-03-27 03:19:24.947691','Kế toán - Kiểm toán','Việc làm kế toán tài chính',8),
	 (1,'2022-03-27 03:19:44.880155','2022-03-27 03:19:44.880155','Tổ chức sự kiện','Việc làm truyền thông media',9),
	 (1,'2022-03-27 03:19:56.991187','2022-03-27 03:19:56.991187','Truyền hình - Báo chí - Biên tập','Việc làm truyền thông media',9),
	 (1,'2022-03-27 03:20:15.800134','2022-03-27 03:20:15.800134','Mỹ thuật - Nghệ thuật - Thiết kế','Việc làm truyền thông media',9),
	 (1,'2022-03-27 03:20:30.825817','2022-03-27 03:20:30.825817','Quảng cáo - Đối ngoại - Truyền thông','Việc làm truyền thông media',9),
	 (1,'2022-03-27 03:20:38.728811','2022-03-27 03:20:38.728811','Giải trí','Việc làm truyền thông media',9),
	 (1,'2022-03-27 03:20:56.520538','2022-03-27 03:20:56.520538','Bất động sản','Việc làm thuộc xây dựng',10),
	 (1,'2022-03-27 03:21:06.105628','2022-03-27 03:21:06.105628','Nội ngoại thất','Việc làm thuộc xây dựng',10),
	 (1,'2022-03-27 03:21:18.368235','2022-03-27 03:21:18.368235','Kiến trúc','Việc làm thuộc xây dựng',10),
	 (1,'2022-03-27 03:21:43.059536','2022-03-27 03:21:43.059536','Công trình thi công','Việc làm thuộc xây dựng',10),
	 (1,'2022-03-27 03:22:04.261952','2022-03-27 03:22:04.261952','Cơ khí - Ô tô - Tự động hóa','Việc làm thuộc kỹ thuật',11),
	 (1,'2022-03-27 03:22:13.985503','2022-03-27 03:22:13.985503','Môi trường','Việc làm thuộc kỹ thuật',11),
	 (1,'2022-03-27 03:22:36.757095','2022-03-27 03:22:36.757095','Điện - Điện tử - Điện lạnh','Việc làm thuộc kỹ thuật',11),
	 (1,'2022-03-27 03:22:44.876468','2022-03-27 03:22:44.876468','Hóa học','Việc làm thuộc kỹ thuật',11),
	 (1,'2022-03-27 03:23:36.728547','2022-03-27 03:23:36.728547','Khoáng sản','Việc làm thuộc kỹ thuật',11),
	 (1,'2022-03-27 03:23:48.418539','2022-03-27 03:23:48.418539','Dầu khí','Việc làm thuộc kỹ thuật',11),
	 (1,'2022-03-27 03:24:08.522143','2022-03-27 03:24:08.522143','Bảo trì - Sửa chữa','Việc làm thuộc kỹ thuật',11),
	 (1,'2022-03-27 03:24:29.912494','2022-03-27 03:24:29.912494','Thư viện','Việc làm thuộc giáo dục và đào tạo',12),
	 (1,'2022-03-27 03:24:57.286293','2022-03-27 03:24:57.286293','Giảng viên - Giáo viên','Việc làm thuộc giáo dục và đào tạo',12),
	 (1,'2022-03-27 03:25:12.610921','2022-03-27 03:25:12.610921','Lâm nghiệp','Việc làm thuộc khoa học',13),
	 (1,'2022-03-27 03:25:24.593729','2022-03-27 03:25:24.593729','Thủy sản - Hải sản','Việc làm thuộc khoa học',13),
	 (1,'2022-03-27 03:26:04.667388','2022-03-27 03:26:04.667388','Công nghệ thục phẩm - Dinh dưỡng','Việc làm thuộc khoa học',13),
	 (1,'2022-03-27 03:26:11.403019','2022-03-27 03:26:11.403019','Thống kê','Việc làm thuộc khoa học',13),
	 (1,'2022-03-27 03:26:32.938066','2022-03-27 03:26:32.938066','Nông nghiệp','Việc làm thuộc khoa học',13),
	 (1,'2022-03-27 03:26:40.145071','2022-03-27 03:26:40.145071','Hàng hải','Việc làm thuộc khoa học',13),
	 (1,'2022-03-27 03:26:50.585657','2022-03-27 03:26:50.586654','Công nghệ sinh học','Việc làm thuộc khoa học',13),
	 (1,'2022-03-27 03:27:04.886507','2022-03-27 03:27:04.886507','Trắc địa - Địa chất','Việc làm thuộc khoa học',13),
	 (1,'2022-03-27 03:27:12.711150','2022-03-27 03:27:12.711150','Thủy lợi','Việc làm thuộc khoa học',13),
	 (1,'2022-03-27 03:27:19.937149','2022-03-27 03:27:19.937149','Chăn nuôi - Thú y','Việc làm thuộc khoa học',13),
	 (1,'2022-03-27 03:27:36.808294','2022-03-27 03:27:36.808294','Du lịch','Việc làm thuộc khách sạn du lịch',14),
	 (1,'2022-03-27 03:27:58.572057','2022-03-27 03:27:58.572057','Nhà hàng - Khách sạn','Việc làm thuộc khách sạn du lịch',14),
	 (1,'2022-03-27 03:28:11.623933','2022-03-27 03:28:11.623933','Hàng không','Việc làm thuộc khách sạn du lịch',14);
INSERT INTO [jobdb].[jobs_user]
           ([password]
           ,[last_login]
           ,[is_superuser]
           ,[username]
           ,[first_name]
           ,[last_name]
           ,[email]
           ,[is_staff]
           ,[is_active]
           ,[date_joined]
           ,[avatar]
           ,[user_role])
     VALUES ('pbkdf2_sha256$320000$UlC7i9o5JVBM8u4wiQzIZQ$F++1Mmt2uIp5vfPhzRM5SzmI4eaaiq+aClm48mG8qRw=','2022-05-11 09:15:42.440990',1,'admin','Nguyễn Long','Nhật','admin@ou.edu.vn',1,1,'2022-04-19 14:39:44.000000','users/2022/04/IMG_2054_lihPXSF.PNG',1),
	 ('pbkdf2_sha256$320000$UlC7i9o5JVBM8u4wiQzIZQ$F++1Mmt2uIp5vfPhzRM5SzmI4eaaiq+aClm48mG8qRw=','2022-04-21 15:37:54.000000',0,'user1','Nguyen Long','Nhat','kennguyen.cr12@gmail.com',1,1,'2022-04-20 01:42:26.000000','users/2022/04/EQVL1008.JPEG',2),
	 ('pbkdf2_sha256$320000$ClVfraz4beTppMBnpsrf7s$cfkjBaBqTE8tPZa7LSrXjshqVYD3q5h1SQY5JpbBay0=',NULL,0,'user2','Nguyễn Ngọc','Phúc','phuc@example.com',0,1,'2022-04-20 03:07:40.000000','users/2022/04/IMG_2058.JPG',3),
	 ('pbkdf2_sha256$320000$ClVfraz4beTppMBnpsrf7s$cfkjBaBqTE8tPZa7LSrXjshqVYD3q5h1SQY5JpbBay0=',NULL,0,'user4','Nguyễn Kiều','Linh','Linhpropro@ou.edu.vn',0,1,'2022-04-26 07:42:59.000000','users/2022/04/IMG_2362.JPG',3),
	 ('pbkdf2_sha256$320000$DxZhnygKAqaqBiHigM1fF7$yboorOP+PCajV1EU+RQDkAXXE+LcU6oxsdyzDwNxfhU=',NULL,0,'hadinh','Đinh Thị Thu','Hà','hadinh@ou.edu.vn',0,1,'2022-04-26 07:48:08.000000','users/2022/04/IMG_2443.JPG',2),
	 ('pbkdf2_sha256$320000$ClVfraz4beTppMBnpsrf7s$cfkjBaBqTE8tPZa7LSrXjshqVYD3q5h1SQY5JpbBay0=',NULL,0,'tien','Võ Mỵ','Thủy Tiên','tien@ou.edu.vn',0,1,'2022-04-26 09:46:02.000000','users/2022/04/IMG_2862.JPG',2),
	 ('pbkdf2_sha256$320000$UlC7i9o5JVBM8u4wiQzIZQ$F++1Mmt2uIp5vfPhzRM5SzmI4eaaiq+aClm48mG8qRw=',NULL,0,'hai','Phan Minh','Hải','kennguyen.crc@gmail.com',0,1,'2022-05-07 15:47:44.000000','users/2022/05/IMG_2893.PNG',2),
	 ('pbkdf2_sha256$320000$UlC7i9o5JVBM8u4wiQzIZQ$F++1Mmt2uIp5vfPhzRM5SzmI4eaaiq+aClm48mG8qRw=',NULL,0,'phucnguyen','Nguyễn Ngọc','Phúc','1951052154phuc@ou.edu.vn',0,1,'2022-05-09 07:35:50.000000','users/2022/05/IMG_2046.JPG',2),
	 ('pbkdf2_sha256$320000$yrqzLuM0TXiCczoeKfaYc7$7fPfqVYWeQOact9qYnzPpi+hRgrqjRdvfQ8HomVr7Os=',NULL,0,'vmtien','Võ Mỵ Thủy','Tiên','tien.vmt.61qtkd@ntu.edu.vn',0,1,'2022-05-09 07:39:19.000000','users/2022/05/IMG_2046_SNMPhlt.JPG',2),
	 ('pbkdf2_sha256$320000$Npm23a1e4D2vdj7opCbh6d$XnfD9pPPJ4I8fHBbahPIdAP6kbWRbrd/FZs5ZeD19po=',NULL,0,'thuminh','Nguyễn Minh','Thư','kennguyen.crc@gmail.com',0,0,'2022-05-09 08:17:46.374198','',2),
	 ('pbkdf2_sha256$320000$ClgMmqsJJDQmom8RQpcNds$5alYGZ9tmDgww1XsWw54eHtsp0LQZBnuuv6V17ABZg4=',NULL,0,'tanhuu','Lê Tấn','Hữu','kennguyen.crc@gmail.com',0,1,'2022-05-09 10:07:49.300664','',2),
	 ('pbkdf2_sha256$320000$rXp3bvdTVMUynlSFxBFQYf$v3IUUVrqbWvcbf7OEVjpYkEsTKySr+fg96pvq8Yd5Ek=',NULL,0,'phuquy','Phạm Phú','Quý','kennguyen.crc@gmail.com',0,1,'2022-05-09 10:16:51.106202','',2),
	 ('pbkdf2_sha256$320000$lnG4xPTy1sIOGOVYsriwjV$5ybv3ubC1TyWk/886WuxDt9eWAAE8x9O5UAzF7hevPI=',NULL,0,'vokieulinh','Nguyễn Võ','Kiều Linh','kennguyen.crc@gmail.com',0,1,'2022-05-15 10:42:39.328639','',2),
	 ('pbkdf2_sha256$320000$wUjlBtOGA2v1vYIjVWgnl7$dI8djs5s0w645fb0vOY4cIXcV5jyl8JBr5eJ6j7IeZs=',NULL,0,'hoai','Nguyễn','Hoài','kennguyen.crc@gmail.com',0,1,'2022-05-15 10:45:22.502096','',2),
	 ('pbkdf2_sha256$320000$BmyZBabmW7rU8MEvZqSSLe$W/rOe/8i/KJmnDNsJ1w2F323r5rLkJqwRN1GHt0Ql7k=',NULL,0,'hoai123','Nguyễn','Hoài','kennguyen.crc@gmail.com',0,1,'2022-05-15 10:50:13.178795','',2),
	 ('pbkdf2_sha256$320000$xDk3pmhFg3sknkWoEEvyXx$k4V7frMQAXRxIJuUBHRasFRvCpfx+Z0c94x2ghxl1U4=',NULL,0,'hoai113','Nguyễn','Hoài','kennguyen.crc@gmail.com',0,1,'2022-05-15 10:55:19.972920','',2),
	 ('pbkdf2_sha256$320000$YcSde070ltzGuMDOMYS3Lk$7Tl0I+xWefqd7me5oXU/3dEvRZiubalGG9T3y7ORjwo=',NULL,0,'nguyenhoai','Nguyễn','Hoài','kennguyen.crc@gmail.com',0,0,'2022-05-15 11:01:23.517033','',2),
	 ('pbkdf2_sha256$320000$S21lklTxJBccoRvlwYaO88$6lecJxwVaYKHTibH8Az4du012Tkag3Y/9RyjOhWl2qw=',NULL,0,'ttken01','','','kennguyen.crc@gmail.com',0,1,'2022-05-15 14:36:08.259482','',2),
	 ('pbkdf2_sha256$320000$JopKF2PXyhhLyEtHM7E1l2$mnej4fnB5AqX/5g2MoqM89Koma/Xg82H34xwoVe+1aM=',NULL,0,'minhnhat','','','kennguyen.crc@gmail.com',0,0,'2022-05-15 14:53:51.281224','',2),
	 ('pbkdf2_sha256$320000$U5v1NNE1N1yPB4u40MWJv4$BXg4tkeFS0cvNIaF0g5SfR0C9mn0IlTnBDl5Pin5XSI=',NULL,0,'kennguyen','','','kennguyen.crc@gmail.com',0,0,'2022-05-15 14:57:34.387228','',2),
	 ('pbkdf2_sha256$320000$UmHFjskLIWIPRNHV3m3Gfx$/zZw3odtj9WgWgOYIGwJpyDUy7lXdqlZlxJQqgE+vag=',NULL,0,'nhatle','','','kennguyen.crc@gmail.com',0,0,'2022-05-15 15:04:26.775877','',2),
	 ('pbkdf2_sha256$320000$xLLF28F9rmUOslTSJ5hS9l$JD+dQ3W0heGGGfLImLrgPW2FgGziqPRudnBjgh6ftxA=',NULL,0,'nhatnguyen','Lưu Nhật','Nguyên','',0,0,'2022-05-15 15:38:12.779402','',2),
	 ('pbkdf2_sha256$320000$YfPIepZHM6IRAeIxqZBgUs$Zob3V+yfyrQtCUn8ziPNRpW+GKGMYxrmUydKcm6ZSiY=',NULL,0,'kennguyen.crc','','','kennguyen.crc@gmail.com',0,0,'2022-05-15 15:44:25.130411','',2),
	 ('pbkdf2_sha256$320000$wZUDMxQZc0gnMQcBmJpdT5$5Yq9exuny/nvYNbp7KM2Thcw+IcmRRaBca9uJ8oEud4=',NULL,0,'1951052144nhat','','','1951052144nhat@ou.edu.vn',0,0,'2022-05-16 08:13:06.780342','users/2022/05/IMG_2056.JPG',2),
	 ('pbkdf2_sha256$320000$PV6tFLgIzt1ewTyMcTTV6g$eMtWkjxjI86ov4qq8x/b6Ej32RgP+EMU4+Cvwn6/bNg=',NULL,0,'ngocngan','','','kennguyen.crc@gmail.com',0,1,'2022-05-16 08:19:39.116007','users/2022/05/IMG_2165.JPG',2),
	 ('pbkdf2_sha256$320000$D7feZR1DkP6P6EQk8COkvq$P7NQLk/dMXtQXBc/np3wAPPepXhzC3ZjqalIjPdw/Qk=',NULL,0,'hoangthai','Hoàng Thái','Phan Thanh','kennguyen.crc@gmail.com',0,1,'2022-05-17 10:33:16.000000','users/2022/05/IMG_2324.JPG',3);
INSERT INTO [jobdb].[jobs_post]
           ([active]
           ,[created_date]
           ,[updated_date]
           ,[title]
           ,[company]
           ,[location]
           ,[from_salary]
           ,[to_salary]
           ,[gender]
           ,[quantity]
           ,[type]
           ,[time_work]
           ,[due]
           ,[description]
           ,[major_id]
           ,[user_id])
     VALUES
 (1,'2022-04-19 15:34:25.734231','2022-04-23 06:18:59.174073','Tuyển nhân viên IT','TAM','Hà Nội',5000000,15000000,'Nam',1,'Thực tập','Fulltime','2022-04-19 15:34:20.000000','<p>C&ocirc;ng việc rất nhẹ nh&agrave;ng<img src=\"/images/posts/2022/04/23/image-20220423131844-1.png\" style=\"height:1080px; width:1920px\" /></p>',25,3),
 (1,'2022-04-26 07:26:32.680415','2022-04-26 07:39:30.734648','Tuyển nhân viên Marketing (Gấp)','MATER','Hồ Chí Minh',5000000,25000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',1,3),
 (1,'2022-04-26 07:30:43.607556','2022-04-26 07:30:43.607556','Tuyển Nhân Viên Marketing','MATERUSER1','Hồ Chí Minh',5000000,25000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',1,3),
 (1,'2022-04-26 07:52:48.912846','2022-04-26 07:52:48.912846','Tuyển DEV BACKEND','TMA SOLUTIONS','Hồ Chí Minh',5000000,25000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',25,4),
 (1,'2022-04-26 08:01:28.698199','2022-04-26 08:17:02.631726','Tuyển DEV DJANGO','TMA SOLUTIONS','Hà Nội',5000000,25000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',25,4),
 (1,'2022-04-26 08:09:19.987390','2022-04-26 08:09:19.987390','Tuyển Thợ Điêu Khắc Gỗ','TMA WOODS','Hà Nội',5000000,25000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',21,4),
 (1,'2022-04-26 08:13:37.531249','2022-04-26 08:13:37.531249','Tuyển Thợ Điêu Khắc Gỗ','TMA WOODS','Hà Nội',10000000,25000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',21,4),
 (1,'2022-04-26 08:30:02.387881','2022-04-26 08:30:02.387881','Tuyển Biên Dịch Viên','TMA ENG','Hà Nội',10000000,25000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-26 08:36:29.665263','2022-04-26 08:36:29.665263','Tuyển Biên Dịch Viên Tiếng Anh','TMA ENG','Hà Nội',10000000,25000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-26 08:39:44.351973','2022-04-26 08:39:44.351973','Tuyển Biên Dịch Viên Tiếng Nhật','TMA JAV','Hà Nội',10000000,25000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 11:00:23.901640','2022-04-27 11:00:23.901640','Tuyển Biên Dịch Viên Tiếng Hàn','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 11:01:13.167862','2022-04-27 11:01:13.167862','Tuyển Biên Dịch Viên Tiếng Hàn','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 11:04:56.546337','2022-04-27 11:04:56.546337','Tuyển Biên Dịch Viên Tiếng Trung','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 11:07:22.838878','2022-04-27 11:07:22.838878','Tuyển Biên Dịch Viên Tiếng Trung','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 11:08:49.824474','2022-04-27 11:08:49.824474','Tuyển Biên Dịch Viên Tiếng Trung','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 11:09:08.696391','2022-04-27 11:09:08.696391','Tuyển Biên Dịch Viên Tiếng Trung','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 11:10:31.645417','2022-04-27 11:10:31.645417','Tuyển Biên Dịch Viên Tiếng Trung','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 11:10:40.684036','2022-04-27 11:10:40.684036','Tuyển Biên Dịch Viên Tiếng Trung','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 11:14:47.438382','2022-04-27 11:14:47.438382','Tuyển Biên Dịch Viên Tiếng Trung','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 11:15:06.201356','2022-04-27 11:15:06.201356','Tuyển Biên Dịch Viên Tiếng Trung','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 11:15:55.856491','2022-04-27 11:15:55.856491','Tuyển Biên Dịch Viên Tiếng Trung','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 11:45:12.956340','2022-04-27 11:45:12.956340','Tuyển Biên Dịch Viên Tiếng Hàn','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 11:45:47.049349','2022-04-27 11:45:47.049349','Tuyển Biên Dịch Viên Tiếng Hàn','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 11:46:49.646185','2022-04-27 11:46:49.646185','Tuyển Biên Dịch Viên Tiếng Hàn','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 12:03:39.365138','2022-04-27 12:03:39.365138','Tuyển Biên Dịch Viên Tiếng Hàn','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 12:04:06.169419','2022-04-27 12:04:06.169419','Tuyển Biên Dịch Viên Tiếng Hàn','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-04-27 12:13:04.095955','2022-04-27 12:13:04.095955','Tuyển Biên Dịch Viên Tiếng Hàn','KOREABIZ','Nha Trang',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-05-15 00:00:00.000000','Một công việc cần sự chuyên môn cao',29,4),
 (1,'2022-05-18 04:47:48.394824','2022-05-18 04:47:48.394824','Tuyển Giảng Viên Công Nghệ Thông Tin','Đại Học Mở TP Hồ Chí Minh','Hồ Chí Minh',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-06-30 00:00:00.000000','Cần tuyển giảng viên môn Công Nghệ Thông Tin, Chuyển về Mạng và framework đang hot hiện nay như: Django, Reactjs, VueJs, JavaSpringBoot. Cần có bằng Đại học liên quan và có chuyên môn về giảng dạy.',52,4),
 (1,'2022-05-18 04:53:15.978724','2022-05-18 04:53:15.978724','Tuyển Biên Tập Viên','THEANH ENTERTAINMENT','Hồ Chí Minh',10000000,35000000,'',NULL,'Chính thức','Fulltime','2022-06-30 00:00:00.000000','Cần tuyển biên tập viên có chuyên môn cao, có tinh thần nhiệt huyết tuổi trẻ và đam mê với nghề.',36,26);
INSERT INTO [jobdb].[jobs_apply]
           ([active]
           ,[created_date]
           ,[updated_date]
           ,[description]
           ,[post_id]
           ,[user_id]
           ,[CV])
     VALUES (1,'2022-04-20 02:16:51.449922','2022-04-20 02:58:14.247896','Nguyễn Long Nhật\r\nDH19',1,1,'applies/2022/04/DienCuuTuTuong.pdf'),
	 (1,'2022-04-20 02:59:32.590690','2022-04-21 15:14:11.031913','Nguyễn Ngọc Phúc\nDH19IT03',1,1,'applies/2022/04/05-reactjs.pdf'),
	 (1,'2022-04-26 08:49:57.826963','2022-05-04 16:24:14.020680','Đinh Thị Thu Hà - 2005',12,5,''),
	 (1,'2022-05-09 07:58:02.755679','2022-05-09 07:58:02.755679','Võ Mỵ Thủy Tiên - Đại Học Nha Trang',24,9,''),
	 (1,'2022-05-15 11:04:17.547260','2022-05-15 11:04:17.547260','Võ Mỵ Thủy Tiên - Đại Học Nha Trang',32,9,''),
	 (1,'2022-05-15 15:57:33.807958','2022-05-15 15:57:33.807958','dataCkeditor',1,9,''),
	 (1,'2022-05-18 04:49:36.879103','2022-05-18 04:49:36.879103','Võ Mỵ Thủy Tiên - Giảng Viên Công Nghệ Thông Tin',33,9,''),
	 (1,'2022-05-18 04:55:03.480470','2022-05-18 04:57:31.136790','Phạm Phú Quý - Cử Nhân Tài Năng Công Nghệ Thông Tin',33,12,''),
	 (1,'2022-05-18 04:55:33.034753','2022-05-18 04:55:33.034753','Phạm Phú Quý - Biên Tập Viên',34,12,'');
INSERT INTO [jobdb].[jobs_comment]
           ([active]
           ,[created_date]
           ,[updated_date]
           ,[content]
           ,[creator_id]
           ,[hirer_id])
     VALUES (1,'2022-05-17 07:24:40.151434','2022-05-17 07:24:40.151434','Nhà tuyển dụng tuyệt vời!!',9,4),
	 (1,'2022-05-17 07:27:06.994623','2022-05-17 07:27:06.994623','Thật tuyệt khi làm việc với nhà tuyển dụng này!!!',9,4);
INSERT INTO [jobdb].[jobs_rating]
           ([active]
           ,[created_date]
           ,[updated_date]
           ,[rate]
           ,[creator_id]
           ,[hirer_id])
     VALUES (1,'2022-05-06 16:18:46.353515','2022-05-06 16:56:14.682113',5,6,4),(1,'2022-05-13 07:50:05.112020','2022-05-13 07:50:05.134129',5,9,4),
	 (1,'2022-05-13 07:50:52.701301','2022-05-13 07:50:59.809554',3,12,4),(1,'2022-05-13 07:51:41.768971','2022-05-13 08:44:30.528637',4,11,4);