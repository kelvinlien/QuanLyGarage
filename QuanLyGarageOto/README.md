--------------------------------------ĐỒ ÁN NHẬP MÔN CÔNG NGHỆ PHẦN MỀM------------------------------------------
Trường: Đại học Công nghệ thông tin - Đại học Quốc gia Thành phố Hồ Chí Minh.

Lớp: Nhập môn Công nghệ Phần mềm - SE104.J22.

Giảng viên phụ trách: cô Đỗ Thị Thanh Tuyền.

///////////////////////////

Đề tài: Quản lý Garage Ô tô.

Nhóm: 19

Thành viên nhóm:

+ Trưởng nhóm: Trần Kim Trung - 16521329

+ Liên Hiệp Quốc - 17520958

\\\\\\\\\\\\\\\\\\\\\\\\\\\

Giới thiệu sơ lược về đồ án:

- Đồ án thực hiện các chức năng theo các yêu cầu và biểu mẫu từ nội dung đề tài. Đồ án được thiết kế đơn giản nhằm đem lại sự thuận tiện cho người dùng.

- Đồ án có tổng cộng 4 form giao diện, lần lượt là: Đăng nhập, Giao diện chính ( Quản lý garage ), Thông tin tài khoản và Thay đổi mật khẩu.
Gần như tất cả các chức năng sẽ được cung cấp qua form Giao diện chính, tiết kiệm cho người dùng thời gian di chuyển giữa các form.

Hướng dẫn sử dụng:

1. Khởi chạy:

- Người dùng nhấp đúp vào file .exe của chương trình để khởi động chương trình. Hoặc, người dùng có thể tìm tên ứng dụng "QuanLyGarage" trên thanh search của Windows.

2. Đăng nhập:

- Ở màn hình Đăng nhập, người dùng đăng nhập với tên tài khoản và mật khẩu được cấp. Phần mềm không hỗ trợ đăng ký tài khoản, chỉ hỗ trợ phân quyền dựa trên các tài khoản có sẵn.

3. Giao diện chính:

- Giao diện chính là nơi cung cấp các chức năng cơ bản và quan trọng của phần mềm. Màn hình giao diện chính có 2 mục Tài khoản và Trợ giúp, 3 tab chức năng chính và tổng cộng 7 tab chức năng thành phần.

- Các chức năng được cung cấp:

	a. Tiếp nhận xe:

- Giới hạn quyền hạn: Không

- Hướng dẫn: Người dùng chọn tab chính Chức năng và tiếp tục chọn tab phụ Tiếp nhận xe.
Bên phải màn hình là danh sách các xe đã được tiếp nhận.
Người dùng nhập các thông tin cần thiết vào các ô bên trái và bấm Thêm xe để thực hiện tiếp nhận.
Khi đã được thông báo tiếp nhận thành công, người dùng có thể nhấn Làm mới ở phía bên phải để cập nhật lại danh sách xe.
Người dùng bấm Clear để thực hiện xóa các thông tin đã nhập vào bên trái và thực hiện nhập thông tin mới.

	b. Lập phiếu sửa chữa:

- Giới hạn quyền hạn: Không

- Hướng dẫn: Người dùng chọn tab chính Chức năng và tiếp tục chọn tab phụ Lập phiếu sửa chữa.
Ngày sửa chữa được lấy tự động là ngày hiện tại của hệ thống.
Người dùng chọn biển số xe được sửa chữa, sau đó tiếp tục thêm các nội dung sửa chữa bằng cách chọn và nhập các nội dung sửa chữa và bấm Nhập VTPT và Nhập tiền công.
Người dùng bấm Hoàn tất để tính tổng tiền, sau đó bấm Lưu phiếu sửa chữa để cập nhật thông tin sửa chữa cho xe vào cơ sở dữ liệu. Người dùng có thể in phiếu sửa chữa nếu muốn bằng nút In phiếu sửa chữa.
Nút Nhập phiếu mới xóa các thông tin hiển thị trên màn hình ( nếu có).

	c. Lập phiếu thu tiền:

- Giới hạn quyền hạn: Không

- Hướng dẫn: Người dùng chọn tab chính Chức năng và tiếp tục chọn tab phụ Lập phiếu thu tiền.
Ngày thu tiền được mặc định là ngày hiện tại của hệ thống.
Người dùng chọn biển số xe cần lập phiếu thu tiền, các thông tin về người sở hữu sẽ tự động hiển thị theo Biển số xe. Người dùng nhập số tiền thu hợp lý và bấm lập phiếu thu tiền để thu.
Người dùng có thể in phiếu thu tiền bằng cách nhấn nút In phiếu thu tiền.
Nút Phiếu thu tiền mới xóa các thông tin hiển thị trên màn hình ( nếu có).

	d. Lập phiếu nhập VTPT:

- Giới hạn quyền hạn: Có. Chỉ tài khoản của Quản lý ( admin) mới có thể sử dụng chức năng này.

- Hướng dẫn: Người dùng chọn tab chính Chức năng và tiếp tục chọn tab phụ Nhập VTPT.
Người dùng chọn các VTPT đã có từ ô Tên Vật Tư Phụ Tùng. Sau khi đã chọn, ô Tên Vật Tư Phụ Tùng Mới, Giá cũng như nút Nhập Mới Vật Tư Phụ Tùng sẽ bị ẩn đi để tránh gây khó khăn cho người dùng.
Người dùng chỉ cần nhập số lượng và bấm Lập phiếu nhập VTPT để thực hiện nhập xuống cơ sở dữ liệu. Nếu nhập mới, người dùng không chọn từ ôn Tên Vật Tư Phụ Tùng mà điền thông tin vào các ô Tên Vật Tư Phụ Tùng Mới, Số lượng, Giá và bấm Nhập Mới Vật Tư Phụ Tùng.
Người dùng có thể in phiếu nhập VTPT bằng cách nhấn nút In phiếu nhập VTPT.
Nút Phiếu nhập VTPT mới xóa các thông tin hiển thị trên màn hình ( nếu có).

	e. Tra cứu:

- Giới hạn quyền hạn: Không.

- Hướng dẫn: Người dùng chọn tab chính Chức năng và tiếp tục chọn tab phụ Tra cứu.
Tra cứu tương đối: Người dùng nhập từ khóa cần tra cứu và bấm Tìm kiếm, bảng bên phải sẽ hiện ra tất cả các kết quả phù hợp với từ khóa đã nhập.
Tra cứu chính xác: Người dùng nhập Biển số và chọn Hiệu xe để tìm chính xác một đối tượng và bấm Tìm kiếm, bảng bên phải sẽ hiển thị kết quả tra cứu.
Nút đặt lại để xóa các thông tin đã nhập vào ( nếu có).

	f. Báo cáo doanh số:

- Giới hạn quyền hạn: Có. Chỉ tài khoản của Quản lý ( admin) mới có thể sử dụng chức năng này.

- Hướng dẫn sử dụng: Người dùng chọn tab chính Báo cáo và tiếp tục chọn tab phụ Báo cáo doanh số.
Người dùng nhập Tháng và Năm để thực hiện lập báo cáo. 2 ô này chỉ nhận các giá trị số nên tránh được việc người dùng nhập nhầm các kí tự khác. Sau đó, người dùng bấm Lập báo cáo để hoàn tất việc tạo báo cáo. Bảng dưới sẽ hiển thị tổng doanh thu cũng như chi tiết báo cáo theo yêu cầu người dùng.
Nút Báo cáo mới xóa các trường đã nhập cũng như báo cáo hiển thị ( nếu có).

	g. Báo cáo tồn:

- Giới hạn quyền hạn: Có. Chỉ tài khoản của Quản lý ( admin) mới có thể sử dụng chức năng này.

- Hướng dẫn sử dụng: Người dùng chọn tab chính Báo cáo và tiếp tục chọn tab phụ Báo cáo tồn.
Người dùng chọn thời điểm lập báo cáo theo tháng và năm. Sau đó, người dùng bấm nút lập báo cáo để tạo báo cáo theo thời điểm đã chọn. Bảng bên dưới hiển thị lại thời điểm báo cáo cũng như chi tiết báo cáo tồn theo yêu cầu người dùng.
Nút Báo cáo mới xóa các trường đã nhập cũng như báo cáo hiển thị ( nếu có).

	h. Thay đổi quy định:

- Giới hạn quyền hạn: Có. Chỉ tài khoản của Quản lý ( admin) mới có thể sử dụng chức năng này.

- Hướng dẫn sử dụng: Người dùng chọn tab chính Quy định.
Người dùng nhập quy định mới theo các ô bên trái màn hình. Sau đó, người dùng nhấn nút Cập nhật mỗi ô thay đổi để cập nhật những quy định mới vào cơ sở dữ liệu. Bảng bên phải sẽ hiển thị các quy định hiện hành. Sau khi cập nhật, người dùng có thể nhấn Làm mới để kiểm tra lại danh sách các quy định đã cập nhật.

	i. Xem thông tin tài khoản:

- Giới hạn quyền hạn: Không.

- Hướng dẫn sử dụng: Người dùng chọn mục Tài khoản và tiếp tục với lựa chọn Thông tin tài khoản ở menu của Tài khoản.
Các thông tin được hiển thị sẽ không thể xóa hay thay đổi.
Người dùng có thể chọn Đổi mật khẩu để đến màn hình đổi mật khẩu, hay Thoát để trở về màn hình Giao diện chính.

	j. Thay đổi mật khẩu:

- Giới hạn quyền hạn: Không.

- Hướng dẫn sử dụng: Người dùng chọn mục Tài khoản, tiếp tục chọn Thông tin tài khoản từ menu của Tài khoản. Sau đó, người dùng nhấn nút Đổi mật khẩu từ màn hình Thông tin tài khoản.
Ô Tài khoản là tên tài khoản hiện tại của người dùng. Người dùng thực hiện nhập lại Mật khẩu cũ, nhập Mật khẩu mới và Xác nhận mật khẩu mới để thay đổi mật khẩu. Người dùng có thể hiện/ẩn mật khẩu bằng nút kế bên mỗi ô. Sau khi nhập xong, người dùng nhấn Lưu thay đổi.
Mật khẩu mới nếu hợp lệ sẽ được cập nhật vào cơ sở dữ liệu. Người dùng sẽ không bị đăng xuất ra, nhưng sẽ cần sử dụng mật khẩu mới từ lần đăng nhập kế tiếp.
Nút Thoát sẽ đưa người dùng về màn hình Thông tin tài khoản. Bấm thoát từ đây sẽ đưa người dùng trở lại màn hình Giao diện chính.

	k. Trợ giúp:

- Giới hạn quyền hạn: Không.

- Hướng dẫn sử dụng: Người dùng chọn mục Trợ giúp kế bên mục Tài khoản. Menu trợ giúp có 2 lựa chọn là Hướng dẫn sử dụng và Liên hệ.
Hướng dẫn sử dụng sẽ thực hiện mở file này lên để người dùng đọc thêm các thông tin cũng như hướng dẫn về các chức năng phần mềm.
Liên hệ sẽ thực hiện mở trình duyệt đến trang GitHub chứa đồ án.

	l. Đăng xuất:

- Giới hạn quyền hạn: Không.

- Hướng dẫn sử dụng: Người dùng chọn mục Tài khoản và lựa chọn Đăng xuất từ menu Tài khoản.
Đăng xuất sẽ đưa người dùng trở về màn hình Đăng nhập và buộc người dùng nhập lại tên tài khoản lẫn mật khẩu nếu muốn đăng nhập lại. Người dùng có thể nhấn Thoát từ đây để thoát khỏi phần mềm.

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Đó là tất cả những chức năng mà phần mềm hỗ trợ người dùng quản lý Garage. Thay mặt nhóm làm đồ án xin chân thành cảm ơn bạn, người dùng!


