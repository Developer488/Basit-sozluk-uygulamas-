using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Clear();

Console.WriteLine("Adınızı  Giriniz.");
string ad = Console.ReadLine();
ad = ad[0].ToString().ToUpper() + ad.Substring(1).ToLower();
Console.WriteLine("Soyadınızı Giriniz.");
string soyad = Console.ReadLine();
soyad = soyad[0].ToString().ToUpper() + soyad.Substring(1).ToLower();
Console.WriteLine($"{ad} {soyad} sözlük uygulamasına Hoş geldiniz.");
string sozluk;
char harf;
Console.Write("Lütfen bir harf giriniz ( A, B, C, Ç, D, E, F, G, H, I, İ, J, K, L, M, N, O, Ö, P, R, S, Ş, T, U, Ü, V, Y, Z ) : ");

if (!char.TryParse(Console.ReadLine(), out harf))
{
    Console.WriteLine("Hatalı giriş. Lütfen harf giriniz. :");

    return;
}

switch (harf)
{

    case 'a':
    case 'A':
        Console.WriteLine("Kelime seçiniz. ( Adalet , Azim , Ahenk , Arzu , Atılım , Atalet , Aforizma , Aleni , Amade , Arı , Asalet , Aşina , Atifet , Ayraç , Azami , Abes , Aplikasyon , Aşikar , Afaroz , Arşiv , Atölye , Akamete Uğramak , Abartı , Asgari , Ayrıcalık , Atıf , Analiz , Aşama , Aracı , Adapte , Aktüel , Abide , Asalak , Aykırı ,  ): ");
        string kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "adalet":
                Console.WriteLine("Adalet: Hak ve hukuka uygunluk, hakkı gözetme anlamına gelir. Toplum düzeninin temel taşı olarak kabul edilir.");
                break;
            case "azim":
                Console.WriteLine("Azim: Bir işteki engelleri yenme kararlılığı, bir şeyi yapma konusundaki güçlü iradedir. Vazgeçmemekle eş anlamlıdır.");
                break;
            case "ahenk":
                Console.WriteLine(" Ahenk: Parçaların birbirine uyumu, düzen ve armonidir. Genellikle müzik, sanat veya toplumsal ilişkiler için kullanılır.");
                break;
            case "arzu":
                Console.WriteLine("Arzu: Bir şeye karşı duyulan şiddetli istek, dilek veya şevktir. Kişiyi harekete geçiren temel duygulardan biridir.");
                break;
            case "atılım":
                Console.WriteLine("Atılım: İleriye doğru yapılan güçlü hamle, ilerleme veya bir işteki büyük girişimdir.");
                break;
            case "atalet":
                Console.WriteLine("Atalet: Hareketsizlik, uyuşukluk veya tembellik demektir. Fizikte ise bir cismin hareket durumunu değiştirmeye karşı gösterdiği dirençtir.");
                break;
            case "aforizma":
                Console.WriteLine("Aforizma: Bir düşünceyi, bir duyguyu veya bir ilkeyi kısa ve özlü bir biçimde anlatan söz, vecize.");
                break;
            case "aleni":
                Console.WriteLine("Aleni: Gizli olmayan, açıkça yapılan, herkesin gözü önünde cereyan eden işler için kullanılır.");
                break;
            case "amade":
                Console.WriteLine("Amade: Hazır, bir işi yapmaya hazır bekleyen anlamındadır.");
                break;
            case "arı":
                Console.WriteLine("Arı: Karışık olmayan, saf, öz, temiz ve kusursuz demektir. Dil bilgisinde yabancı kelimelerden arınmış dil için de kullanılır.");
                break;
            case "asalet":
                Console.WriteLine(" Asalet: Soyluluk, doğuştan gelen veya sonradan kazanılan ruh yüceliği, efendilik.");
                break;
            case "aşina":
                Console.WriteLine("Aşina: Tanıdık, bildik, yabancı olmayan. Bir konuyu iyi bilen kişiler için de kullanılır.");
                break;
            case "atifet":
                Console.WriteLine("Atifet: Karşılık beklemeden yapılan iyilik, lütuf veya ihsan anlamındadır.");
                break;
            case "ayraç":
                Console.WriteLine("Ayraç: Bir metinde parantez (( )) işaretine verilen isimdir. Ayrıca maddeleri birbirinden ayırmaya yarayan her türlü engel veya işaret için kullanılır.");
                break;
            case "azami":
                Console.WriteLine("Azami: Bir şeyin ulaşabileceği en yüksek, en büyük veya en üst sınır. Asgari (en az) kelimesinin zıttıdır.");
                break;
            case "abes":
                Console.WriteLine("Abes: Akla ve gerçeğe aykırı, saçma, yersiz veya boş uğraş anlamlarına gelir.");
                break;
            case "aplikasyon":
                Console.WriteLine("Aplikasyon: Özellikle teknoloji dünyasında sıkça kullandığın bir terimdir. \"Uygulama\" veya bir şeyi bir yere tatbik etme, uygulama süreci demektir.");
                break;
            case "aşikar":
                Console.WriteLine("Aşikar: Görünür, apaçık, belli, gizli olmayan demektir.");
                break;
            case "aforoz":
                Console.WriteLine("Aforoz: Birini bir topluluktan dışlamak, kovmak veya eskiden kilisenin dinden çıkarma cezasıdır. Günlük dilde ilişkiyi kesmek anlamında da kullanılır.");
                break;
            case "arşiv":
                Console.WriteLine("Arşiv: Belgelik; belgelerin, dosyaların veya verilerin saklandığı yer ya da bu saklanan belgelerin tamamıdır.");
                break;
            case "atölye":
                Console.WriteLine("Atölye: Zanaatçıların veya sanatçıların çalıştığı yer; işlik. Günümüzde yazılım dünyasında workshop (çalıştay) anlamında da sık kullanılır.");
                break;
            case "akamete uğramak":
                Console.WriteLine("Akamete Uğramak: Bir işin başarısızlıkla sonuçlanması, kesintiye uğraması veya sonuçsuz kalmasıdır.");
                break;
            case "abartı":
                Console.WriteLine("Abartı: Bir şeyi olduğundan daha büyük veya daha çok gösterme, aşırıya kaçma.");
                break;
            case "asgari":
                Console.WriteLine("Asgari: Bir şey için gerekli olan en az, en alt veya en düşük miktar. Azami kelimesinin tam tersidir.");
                break;
            case "ayrıcalık":
                Console.WriteLine("Ayrıcalık: Başkalarına tanınmayan özel hak, imtiyaz veya üstünlük durumu.");
                break;
            case "atıf":
                Console.WriteLine("Atıf: Bir durumu bir yere dayandırma, yöneltme veya bir kaynağa gönderme yapma (referans verme).");
                break;
            case "analiz":
                Console.WriteLine("Analiz: Bir konuyu, bir maddeyi veya bir sorunu temel parçalarına ayırarak inceleme, çözümleme.");
                break;
            case "aksiyon":
                Console.WriteLine("Aksiyon: Hareket, eylem veya bir işin yapılması süreci.");
                break;
            case "aşama":
                Console.WriteLine("Aşama: Bir süreçteki basamaklardan her biri, evre veya mertebe");
                break;
            case "aracı":
                Console.WriteLine("Aracı: İki taraf arasında bağlantı kuran, uzlaşma sağlayan veya bir şeyin iletilmesine yardım eden kişi ya da kurum.");
                break;
            case "adapte":
                Console.WriteLine("Adapte: Bir şeye uymak, uyum sağlamak veya yerleşmek.");
                break;
            case "aktüel":
                Console.WriteLine("Aktüel: Güncel olan, o anı ilgilendiren, şimdiki zamanla ilgili.");
                break;
            case "abide":
                Console.WriteLine("Abide: Anıt; önemli bir olayı veya kişiyi yaşatmak için yapılan büyük yapı. Mecazen (çok görkemli eser) anlamında da kullanılır.");
                break;
            case "asalak":
                Console.WriteLine("Asalak: Bir canlının üzerinde yaşayıp ondan beslenen canlı (parazit). Mecazen, çalışmadan başkasının sırtından geçinen kişi.");
                break;
            case "aykırı":
                Console.WriteLine("Aykırı: Alışılmışa uymayan, ters düşen, kural dışı veya zıt.");
                break;
                break;
            default:
                Console.WriteLine("Bilinmeyen kelime !");
                break;
        }
        break;
    case 'b':
    case 'B': sozluk = "B harfini seçtinizç";
        Console.WriteLine("Kelime seçiniz. (Batuhan , Basiret , Berrak , Bütünleşik , Beyan , Bakiye , Bedbin , Belagat , Bizar , Bilinç , Banal , Beceri , Bilge , Bidayet , Bitek , Boyut , Branş , Brifing , Bulgu , Bühtan ,Bağımsız , Bağdaşmak , Bağnaz , Bahis , Bahtiyar , Bakış , Balans , Bariz , Basamak , Basit , Baskın , Başarı , Başat , Batıl , Becerikli , Bedel , Beğeni , Beklenti , Belge , Belirgin , Belirti , Bellek , Benlik , Benzerlik , Beraberlik , Bereket , Betimleme , Beyin , Biçim , Bilgi ): ");
         kelimeler = Console.ReadLine().ToLower();
        switch (kelimeler)
        {
            case "batuhan":
                Console.WriteLine("Güçlü Hükümdar , Yenilmez Lider veya Sert ve Kuvvetli Yönetici");
                break;
            case "bağlam":
                Console.WriteLine("Bağlam: Bir olayın veya sözün gerçekleştiği ortam, durum veya kendisinden önce ve sonra gelen bölümlerle olan ilişkisi. Yazılımda \"context\" kavramı çok kritiktir.");
                break;
            case "basiret":
                Console.WriteLine("Basiret: Gerçekleri görme, uzağı görme, sağduyu ve anlama yeteneği.");
                break;
            case "berrak":
                Console.WriteLine("Berrak: Duru, temiz, aydınlık ve bulanık olmayan.");
                break;
            case "bütünleşik":
                Console.WriteLine("Bütünleşik: Bir araya getirilmiş, birbirine eklemlenmiş veya birleşmiş yapılar.");
                break;
            case "beyan":
                Console.WriteLine("Beyan: Bildirme, söyleme, açıkça ortaya koyma veya resmi açıklama.");
                break;
            case "bakiye":
                Console.WriteLine("Bakiye: Geriye kalan miktar, artan kısım. Genellikle bankacılık ve hesap işlemlerinde kullanılır.");
                break;
            case "bedbin":
                Console.WriteLine("Bedbin: Kötümser, her şeyi karanlık gören, umutsuz. İyimser (Nikbin) kelimesinin zıttıdır.");
                break;
            case "belagat":
                Console.WriteLine("Belagat: Sözü yerinde, düzgün ve etkileyici söyleme sanatı. Güzel konuşma yeteneği.");
                break;
            case "bizar":
                Console.WriteLine("Bizar: Bezmiz, bıkmış, usanmış veya rahatsız olmuş.");
                break;
            case "bilinç":
                Console.WriteLine("Bilinç: İnsanın kendisini ve çevresini fark etme yeteneği, şuur.");
                break;
            case "banal":
                Console.WriteLine("Banal: Sıradan, herkesçe bilinen, hiçbir özelliği olmayan, bayat.");
                break;
            case "beceri":
                Console.WriteLine("Beceri: Elden gelen iş yapma yeteneği, maharet.");
                break;
            case "bilge":
                Console.WriteLine("Bilge: Bilgili, görgülü, erdemli ve olgun kişi.");
                break;
            case "bidayet":
                Console.WriteLine("Bidayet: Başlangıç, bir işin ilk evresi.");
                break;
            case "bitek":
                Console.WriteLine("Bitek: Verimli, üzerinde bol ürün yetişen (toprak için kullanılır).");
                break;
            case "boyut":
                Console.WriteLine("Boyut: Genişlik, uzunluk ve derinlikten her biri. Mecazen bir işin kapsamı.");
                break;
            case "branş":
                Console.WriteLine("Branş: Dal, kol, uzmanlık alanı.");
                break;
            case "brifing":
                Console.WriteLine("Brifing: Bir konuda verilen kısa ve özlü bilgi, bilgilendirme toplantısı.");
                break;
            case "bulgu":
                Console.WriteLine("Bulgu: Araştırma veya inceleme sonucunda elde edilen veri, saptama.");
                break;
            case "bühtan":
                Console.WriteLine("Birine aslı olmayan, kötü bir durumu yükleme; iftira.");
                break;
            case "bağımsız":
                Console.WriteLine("Bağımsız: Hiçbir yere bağlı olmayan, özgür.");
                break;
            case "bağdaşmak":
                Console.WriteLine("Bağdaşmak: İki durumun birbirine uyması, çelişmemesi.");
                break;
            case "bağnaz":
                Console.WriteLine("Bağnaz: Bir düşünceye körü körüne bağlı olan, yobaz.");
                break;
            case "bahis":
                Console.WriteLine("Bahis: Üzerinde konuşulan konu veya söz.");
                break;
            case "bahtiyar":
                Console.WriteLine("Bahtiyar: Mutlu, mesut, halinden memnun.");
                break;
            case "bakış":
                Console.WriteLine("Bakış: Bir olayı değerlendirme biçimi, perspektif.");
                break;
            case "balans":
                Console.WriteLine("Balans: Dengeleme, denge durumu.");
                break;
            case "bariz":
                Console.WriteLine("Bariz: Çok açık, net, gözle görülebilir.");
                break;
            case "basamak":
                Console.WriteLine("Basamak: Bir süreçteki aşamaların her biri.");
                break;
            case "basit":
                Console.WriteLine("Basit: Karmaşık olmayan, kolay anlaşılan.");
                break;
            case "baskın":
                Console.WriteLine("Baskın: Diğerlerine göre daha güçlü veya ön planda olan.");
                break;
            case "başarı":
                Console.WriteLine("Başarı: İstenilen sonuca ulaşma durumu.");
                break;
            case "başat":
                Console.WriteLine("Başat: En önemli, en başta gelen, hakim unsur.");
                break;
            case "batıl":
                Console.WriteLine("Batıl: İnanç sisteminde aslı olmayan, yanlış.");
                break;
            case "becerikli":
                Console.WriteLine("Becerikli: İş elinden gelen, usta.");
                break;
            case "bedel":
                Console.WriteLine("Bedel: Bir şeyin karşılığı olarak ödenen değer.");
                break;
            case "beğeni":
                Console.WriteLine("Beğeni: Estetik zevk, hoşlanma duygusu.");
                break;
            case "beklenti":
                Console.WriteLine("Beklenti: Gerçekleşmesi umulan durum.");
                break;
            case "belge":
                Console.WriteLine("Belge: Bir durumu kanıtlayan yazılı kâğıt, doküman.");
                break;
            case "belirgin":
                Console.WriteLine("Belirgin: Kolayca fark edilen, belirmiş olan.");
                break;
            case "belirti":
                Console.WriteLine("Belirti: Bir durumun varlığını gösteren işaret, semptom.");
                break;
            case "bellek":
                Console.WriteLine("Bellek: Bilgileri saklama ve hatırlama yetisi (Memory).");
                break;
            case "benlik":
                Console.WriteLine("Benlik: Kişinin kendi özü, kişiliği.");
                break;
            case "benzerlik":
                Console.WriteLine("Benzerlik: İki şey arasındaki ortak özellikler.");
                break;
            case "beraberlik":
                Console.WriteLine("Beraberlik: Birlikte olma durumu veya eşitlik.");
                break;
            case "bereket":
                Console.WriteLine("Bereket: Bolluk, gürlük, verimlilik.");
                break;
            case "betimleme":
                Console.WriteLine("Betimleme: Bir şeyi kelimelerle resmetme, tasvir etme.");
                break;
            case "beyin":
                Console.WriteLine("Beyin: Sinir sisteminin merkezi, düşünme organı.");
                break;
            case "biçim":
                Console.WriteLine("Biçim: Form, şekil veya tarz.");
                break;
            case "bilgi":
                Console.WriteLine("Bilgi: Öğrenme veya gözlem yoluyla elde edilen gerçek.");
                break;
            default:
                Console.WriteLine("Bilinmeyen kelime ! ");
                break;
        }
        break;

    case 'c':
    case 'C':
        Console.WriteLine("Kelime seçiniz. (  Cazibe, Cefa, Celal, Cemiyet, Cenah, Cevaz, Cevher, Cevval, Cezbe, Cihan, Cinas, Cisim, Coşku, Cömert, Cüret, Cüsse, Cüzi, Canan, Camia, Cahil, Cari, Ciro, Celse, Cihaz, Ciddi, Civar, Cunta, Caydırıcı, Cebir, Cebren, Cedid, Ceht, Cenk, Cevap, Cila, Cilt, Cılız, Cismani, Cumhur, Casus, Cabadan, Cadde, Caiz, Canlı, Ceviz, Cıvıl, Cicim, Cizye, Cura, Cübbe ): ");
         kelimeler = Console.ReadLine().ToLower();


        switch (kelimeler)
            
        {
            case "cazibe":
                Console.WriteLine("Cazibe: Çekicilik, albeni, mıknatıs etkisi yaratan güzellik.");
                break;
            case "cefa":
                Console.WriteLine("Cefa: Eziyet, sıkıntı, büyük üzüntü ve dert.");
                break;
            case "celal":
                Console.WriteLine("Celal: Öfke, kızgınlık; büyüklük ve ululuk.");
                break;
            case "cemiyet":
                Console.WriteLine("Cemiyet: Toplum, birlik, belirli bir amaçla kurulan dernek.");
                break;
            case "cenah":
                Console.WriteLine("Cenah: Yan, taraf, kanat (siyasi veya askeri bir grubun kolu).");
                break;
            case "cevaz":
                Console.WriteLine("Cevaz: İzin verme, uygun görme, müsaade etme.");
                break;
            case "cevher":
                Console.WriteLine("Cevher: Bir şeyin özü; değerli taş, işlenmemiş maden.");
                break;
            case "cevval":
                Console.WriteLine("Cevval: Hareketli, becerikli, yerinde duramayan ve atak.");
                break;
            case "cezbe":
                Console.WriteLine("Cezbe: Kendinden geçme durumu, aşırı heyecan ve coşku.");
                break;
            case "cihan":
                Console.WriteLine("Cihan: Dünya, evren, tüm insanlık ve kainat.");
                break;
            case "cinas":
                Console.WriteLine("Cinas: Yazılışları aynı, anlamları farklı kelimelerin bir arada kullanılması.");
                break;
            case "cisim":
                Console.WriteLine("Cisim: Madde, gövde, somut ve yer kaplayan varlık.");
                break;
            case "coşku":
                Console.WriteLine("Coşku: Heyecan ve sevinçle gelen güçlü ruh hali.");
                break;
            case "cömert":
                Console.WriteLine("Cömert: Eli açık, paylaşmayı seven ve ikramda bulunan.");
                break;
            case "cüret":
                Console.WriteLine("Cüret: Cesaret, yiğitlik; bazen de saygısızca yapılan ataklık.");
                break;
            case "cüsse":
                Console.WriteLine("Cüsse: Gövde büyüklüğü, kalıp, fiziksel heybet.");
                break;
            case "cüzi":
                Console.WriteLine("Cüzi: Çok az, küçük miktar, önemsiz derecede düşük.");
                break;
            case "canan":
                Console.WriteLine("Canan: Gönül verilmiş olan, çok sevilen sevgili.");
                break;
            case "camia":
                Console.WriteLine("Camia: Topluluk, zümre, ortak özelliklere sahip grup.");
                break;
            case "cahil":
                Console.WriteLine("Cahil: Bilgisiz, öğrenim görmemiş, tecrübesiz.");
                break;
            case "cari":
                Console.WriteLine("Cari: Akışta olan, yürürlükte olan, geçerliliğini koruyan.");
                break;
            case "ciro":
                Console.WriteLine("Ciro: Bir işletmenin belirli bir dönemdeki toplam satış hasılatı.");
                break;
            case "celse":
                Console.WriteLine("Celse: Oturum (mahkeme veya resmi toplantıların bölümleri).");
                break;
            case "cihaz":
                Console.WriteLine("Cihaz: Mekanik veya elektronik aygıt, düzenek.");
                break;
            case "ciddi":
                Console.WriteLine("Ciddi: Şaka olmayan, ağırbaşlı, üzerinde durulması gereken.");
                break;
            case "civar":
                Console.WriteLine("Civar: Çevre, yöre, yakındaki yerler.");
                break;
            case "cunta":
                Console.WriteLine("Cunta: Yönetimi ele geçiren darbeci grup.");
                break;
            case "caydırıcı":
                Console.WriteLine("Caydırıcı: Bir işten vazgeçirme gücü olan engel.");
                break;
            case "cebir":
                Console.WriteLine("Cebir: Zorlama; matematikte sembollerle işlem yapılan dal.");
                break;
            case "cebren":
                Console.WriteLine("Cebren: Zor kullanarak, zorla, irade dışı.");
                break;
            case "cedid":
                Console.WriteLine("Cedid: Yeni, modern, güncel olan.");
                break;
            case "ceht":
                Console.WriteLine("Ceht: Çaba, büyük gayret, var gücüyle çalışma.");
                break;
            case "cenk":
                Console.WriteLine("Cenk: Savaş, büyük mücadele, çarpışma.");
                break;
            case "cevap":
                Console.WriteLine("Cevap: Yanıt, bir soruya veya söze verilen karşılık.");
                break;
            case "cila":
                Console.WriteLine("Cila: Parlatıcı madde; dış görünüşteki sahte parlaklık.");
                break;
            case "cilt":
                Console.WriteLine("Cilt: Deri; kitap kaplaması; serinin her bir kitabı.");
                break;
            case "cılız":
                Console.WriteLine("Cılız: Zayıf, kuvvetsiz, etkisiz ve dayanıksız.");
                break;
            case "cismani":
                Console.WriteLine("Cismani: Bedensel, maddi, ruhani olmayan varlık.");
                break;
            case "cumhur":
                Console.WriteLine("Cumhur: Halk, topluluk, kalabalık insan grubu.");
                break;
            case "casus":
                Console.WriteLine("Casus: Gizli bilgi sızdıran, ajan.");
                break;
            case "cabadan":
                Console.WriteLine("Cabadan: Bedava, fazladan, karşılıksız elde edilen.");
                break;
            case "cadde":
                Console.WriteLine("Cadde: Şehir içindeki ana ve geniş yol.");
                break;
            case "caiz":
                Console.WriteLine("Caiz: Yapılmasında sakınca olmayan, dinen veya hukuken uygun.");
                break;
            case "canlı":
                Console.WriteLine("Canlı: Yaşayan; hareketli, enerjik ve hayat dolu.");
                break;
            case "ceviz":
                Console.WriteLine("Ceviz: Sert kabuklu, beyne benzeyen besleyici yemiş.");
                break;
            case "cıvıl":
                Console.WriteLine("Cıvıl: Sesli ve hareketli (kuş veya çocuk cıvıltısı için).");
                break;
            case "cicim":
                Console.WriteLine("Cicim: Bir dokuma türü; sevgi ve samimiyet sözü.");
                break;
            case "cizye":
                Console.WriteLine("Cizye: Eski İslam devletlerinde gayrimüslimlerden alınan vergi.");
                break;
            case "cura":
                Console.WriteLine("Cura: Küçük bir bağlama türü, ince sesli saz.");
                break;
            case "cübbe":
                Console.WriteLine("Cübbe: Hakimlerin veya din adamlarının giydiği geniş kıyafet.");
                break;

    default:
                Console.WriteLine("Bilinmeyen kelime !");
                break;
        }
        break;

    case 'ç':
    case 'Ç':
        Console.WriteLine("Kelime seçiniz. (  Çaba, Çağdaş, Çağrışım, Çakışma, Çalıştay, Çap, Çapraz, Çaresiz, Çark, Çatışma, Çatlak, Çatı, Çekince, Çekirdek, Çekişme, Çelişki, Çerçeve, Çeşitlilik, Çetin, Çevik, Çeviri, Çevre, Çeyiz, Çıkarım, Çıktı, Çıraklık, Çizge, Çizgi, Çizim, Çizme, Çoğul, Çoğunluk, Çoklu, Çokgen, Çorak, Çözüm, Çözümleme, Çözünürlük, Çubuk, Çukur, Çul, Çünkü, Çürütme, Çüş, Çılgın, Çan, Çember, Çerçeveleme, Çatlaklık, Çürüme ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)

        {
            case "çaba":
                Console.WriteLine("Çaba: Bir işi başarmak için harcanan güç, gayret.");
                break;
            case "çağdaş":
                Console.WriteLine("Çağdaş: Aynı çağda yaşayan, bulunulan çağın anlayışına uygun olan (Modern).");
                break;
            case "çağrışım":
                Console.WriteLine("Çağrışım: Bir düşünce veya nesnenin başka bir şeyi hatırlatması.");
                break;
            case "çakışma":
                Console.WriteLine("Çakışma: İki şeyin aynı zamana veya noktaya denk gelmesi (Conflict).");
                break;
            case "çalıştay":
                Console.WriteLine("Çalıştay: Uzmanların bir konuda bilgi alışverişinde bulunduğu toplantı (Workshop).");
                break;
            case "çap":
                Console.WriteLine("Çap: Bir dairenin merkezinden geçen doğru; mecazen yetenek ve bilgi düzeyi.");
                break;
            case "çapraz":
                Console.WriteLine("Çapraz: Birbirini kesen, yanlamasına olan.");
                break;
            case "çaresiz":
                Console.WriteLine("Çaresiz: Çözüm yolu kalmamış, elinden bir şey gelmeyen.");
                break;
            case "çark":
                Console.WriteLine("Çark: Dişli tekerlek; mecazen bir sistemin işleyen parçası.");
                break;
            case "çatışma":
                Console.WriteLine("Çatışma: Karşıt düşüncelerin veya güçlerin birbirine ters düşmesi.");
                break;
            case "çatlak":
                Console.WriteLine("Çatlak: Bir yüzeydeki ince yarık; mecazen bir yapıdaki bozulma.");
                break;
            case "çatı":
                Console.WriteLine("Çatı: Bir yapının en üst kısmı; mecazen bir organizasyonun kapsayıcı yapısı.");
                break;
            case "çekince":
                Console.WriteLine("Çekince: Bir konuda duyulan şüphe veya sakınca görme durumu.");
                break;
            case "çekirdek":
                Console.WriteLine("Çekirdek: Bir şeyin merkezi, en iç kısmı (Kernel/Core).");
                break;
            case "çekişme":
                Console.WriteLine("Çekişme: Üstün gelmek için yapılan karşılıklı mücadele.");
                break;
            case "çelişki":
                Console.WriteLine("Çelişki: İki durumun veya sözün birbirini tutmaması (Paradox).");
                break;
            case "çerçeve":
                Console.WriteLine("Çerçeve: Bir şeyi çevreleyen kenarlık; mecazen bir konunun sınırları (Framework).");
                break;
            case "çeşitlilik":
                Console.WriteLine("Çeşitiilik: Bir yapı içindeki farklı türlerin çokluğu (Diversity).");
                break;
            case "çetin":
                Console.WriteLine("Çetin: Başarılması güç, sert ve zorlu.");
                break;
            case "çevik":
                Console.WriteLine("Çevik: Hızlı ve kolay hareket edebilen; yazılımda esnek süreç yönetimi (Agile).");
                break;
            case "çeviri":
                Console.WriteLine("Çeviri: Bir dilden başka bir dile aktarma işlemi.");
                break;
            case "çevre":
                Console.WriteLine("Çevre: Bir şeyin dış kenarı veya canlıların içinde bulunduğu ortam.");
                break;
            case "çeyiz":
                Console.WriteLine("Çeyiz: Evlenecek kişiye sağlanan her türlü eşya.");
                break;
            case "çıkarım":
                Console.WriteLine("Çıkarım: Verilen bilgilerden sonuç elde etme süreci (Inference).");
                break;
            case "çıktı":
                Console.WriteLine("Çıktı: Bir işlemin veya programın ürettiği sonuç (Output).");
                break;
            case "çıraklık":
                Console.WriteLine("Çıraklık: Bir zanaatı öğrenmek için geçirilen ilk evre.");
                break;
            case "çizge":
                Console.WriteLine("Çizge: Verilerin birbirine bağlanışını gösteren şema (Graph).");
                break;
            case "çizgi":
                Console.WriteLine("Çizgi: Bir noktadan diğerine giden hat; mecazen kural veya tarz.");
                break;
            case "çizim":
                Console.WriteLine("Çizim: Bir şeyin taslağını oluşturma.");
                break;
            case "çizme":
                Console.WriteLine("Çizme: Boyu dizlere kadar gelen ayakkabı; mecazen iptal etme.");
                break;
            case "çoğul":
                Console.WriteLine("Çoğul: Birden fazla olan (Plural).");
                break;
            case "çoğunluk":
                Console.WriteLine("Çoğunluk: Bir gruptaki sayının yarıdan fazlası.");
                break;
            case "çoklu":
                Console.WriteLine("Çoklu: Birden fazla parçadan oluşan (Multi).");
                break;
            case "çokgen":
                Console.WriteLine("Çokgen: Kenar sayısı üçten fazla olan kapalı şekil.");
                break;
            case "çorak":
                Console.WriteLine("Çorak: Verimsiz, üzerinde bir şey yetişmeyen.");
                break;
            case "çözüm":
                Console.WriteLine("Çözüm: Bir sorunun giderilme yolu (Solution).");
                break;
            case "çözümleme":
                Console.WriteLine("Çözümleme: Bir şeyi parçalarına ayırarak inceleme (Analysis).");
                break;
            case "çözünürlük":
                Console.WriteLine("Çözünürlük: Bir görüntüyü oluşturan detay netliği (Resolution).");
                break;
            case "çubuk":
                Console.WriteLine("Çubuk: İnce ve uzun parça; yazılımda menü çubuğu (Bar).");
                break;
            case "çukur":
                Console.WriteLine("Çukur: Derinleşmiş yer, oyuk.");
                break;
            case "çul":
                Console.WriteLine("Çul: Kaba dokuma; mecazen giysi.");
                break;
            case "çünkü":
                Console.WriteLine("Çünkü: Neden belirten bağlaç.");
                break;
            case "çürütme":
                Console.WriteLine("Çürütme: Bir savın yanlışlığını kanıtlama.");
                break;
            case "çüş":
                Console.WriteLine("Çüş: Durdurma ünlemi; şaşkınlık ifadesi.");
                break;
            case "çılgın":
                Console.WriteLine("Çılgın: Aşırı davranışlarda bulunan, delişmen.");
                break;
            case "çan":
                Console.WriteLine("Çan: Madeni ses verme aleti; uyarı simgesi.");
                break;
            case "çember":
                Console.WriteLine("Çember: Bir noktaya eşit uzaklıktaki noktalar kümesi.");
                break;
            case "çerçeveleme":
                Console.WriteLine("Çerçeveleme: Bir konuyu belirli sınırlar içinde ele alma.");
                break;
            case "çatlaklık":
                Console.WriteLine("Çatlaklık: Yüzeyin bütünlüğünün bozulması durumu.");
                break;
            case "çürüme":
                Console.WriteLine("Çürüme: Maddenin kimyasal olarak bozulması; mecazen yozlaşma.");
                break;

            default:
                Console.WriteLine("Bilinmeyen kelime !");
                break;
        }
        break;


    case 'd':
    case 'D':
        Console.WriteLine("Kelime seçiniz. ( Dinamik, Dirayet, Deha, Donanım, Değişken, Döngü, Denetim, Destek, Diyalog, Darboğaz, Dalgalanma, Darphane, Davet, Dayanak, Dayanıklılık, Debdebeli, Değer, Dejenerasyon, Deklare, Demeç, Demografi, Deneyim, Denge, Denklem, Depozito, Derinlik, Derman, Despot, Detay, Devinim, Devre, Dışlama, Dikkat, Dilemma, Dönüşüm, Diksiyon, Diplomasi, Disiplin, Distribütör, Divan, Diğerkâm, Doktrin, Doküman, Dolaylı, Dönemeç, Doruk, Dosya, Dozaj, Dramatik, Düstur ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)

        {
            case "dinamik":
                Console.WriteLine("Dinamik: Hareketli, değişken, canlı ve sürekli gelişen.");
                break;
            case "dirayet":
                Console.WriteLine("Dirayet: Bir işi başarma yeteneği, kavrayış ve zekâ.");
                break;
            case "deha":
                Console.WriteLine("Deha: Olağanüstü yetenek ve yaratıcı gücü olan kimse.");
                break;
            case "donanım":
                Console.WriteLine("Donanım: Bir bilgisayar sistemini oluşturan fiziksel parçaların bütünü.");
                break;
            case "değişken":
                Console.WriteLine("Değişken: Farklı değerler alabilen nicelik veya yazılımdaki veri saklayıcı (Variable).");
                break;
            case "döngü":
                Console.WriteLine("Döngü: Belirli bir işlemin tekrar edilmesi süreci (Loop).");
                break;
            case "denetim":
                Console.WriteLine("Denetim: Bir işin kuralına uygun yapılıp yapılmadığını inceleme, kontrol.");
                break;
            case "destek":
                Console.WriteLine("Destek: Bir şeyin yıkılmasını önleyen dayanak veya yardım.");
                break;
            case "diyalog":
                Console.WriteLine("Diyalog: İki veya daha çok kişi arasındaki karşılıklı konuşma.");
                break;
            case "darboğaz":
                Console.WriteLine("Darboğaz: Bir sürecin ilerlemesini engelleyen en dar veya sorunlu nokta.");
                break;
            case "dalgalanma":
                Console.WriteLine("Dalgalanma: Fiyatların veya verilerin belirli bir aralıkta inip çıkması.");
                break;
            case "darphane":
                Console.WriteLine("Darphane: Para basılan yer.");
                break;
            case "davet":
                Console.WriteLine("Davet: Çağrı, bir yere gelmesini isteme.");
                break;
            case "dayanak":
                Console.WriteLine("Dayanak: Bir düşünceyi veya durumu destekleyen temel.");
                break;
            case "dayanıklılık":
                Console.WriteLine("Dayanıklılık: Dış etkilere karşı direnç gösterme gücü.");
                break;
            case "debdebeli":
                Console.WriteLine("Debdebeli: Gösterişli, görkemli ve şatafatlı.");
                break;
            case "değer":
                Console.WriteLine("Değer: Bir şeyin önemini belirleyen ölçü veya kıymet.");
                break;
            case "dejenerasyon":
                Console.WriteLine("Dejenerasyon: Yozlaşma, aslından uzaklaşma ve bozulma.");
                break;
            case "deklare":
                Console.WriteLine("Deklare: Resmen bildirme, ilan etme.");
                break;
            case "demeç":
                Console.WriteLine("Demeç: Yetkili bir kişinin yayın organlarına yaptığı açıklama.");
                break;
            case "demografi":
                Console.WriteLine("Demografi: Nüfus yapısını inceleyen bilim dalı.");
                break;
            case "deneyim":
                Console.WriteLine("Deneyim: Tecrübe; bir işi yaparak kazanılan bilgi.");
                break;
            case "denge":
                Console.WriteLine("Denge: İki güç arasındaki eşitlik durumu.");
                break;
            case "denklem":
                Console.WriteLine("Denklem: İçinde bilinmeyen bulunan matematiksel eşitlik.");
                break;
            case "depozito":
                Console.WriteLine("Depozito: Bir güvence olarak önceden verilen para.");
                break;
            case "derinlik":
                Console.WriteLine("Derinlik: Bir şeyin yüzeyden tabana olan uzaklığı veya kapsamı.");
                break;
            case "derman":
                Console.WriteLine("Derman: Çare, ilaç veya güç, takat.");
                break;
            case "despot":
                Console.WriteLine("Despot: Buyurgan, zorba, her istediğini yaptırmak isteyen.");
                break;
            case "detay":
                Console.WriteLine("Detay: Bir bütünün küçük ve ayrıntılı parçalarından her biri.");
                break;
            case "devinim":
                Console.WriteLine("Devinim: Hareket, bir durumdan başka bir duruma geçiş.");
                break;
            case "devre":
                Console.WriteLine("Devre: Dönem; elektrik akımının izlediği yol.");
                break;
            case "dışlama":
                Console.WriteLine("Dışlama: Birini veya bir şeyi topluluğun dışında bırakma.");
                break;
            case "dikkat":
                Console.WriteLine("Dikkat: Zihnin bir konu üzerinde yoğunlaşması.");
                break;
            case "dilemma":
                Console.WriteLine("Dilemma: İki seçenek arasında karar verememe durumu, ikilem.");
                break;
            case "dönüşüm":
                Console.WriteLine("Dönüşüm: Bir biçimden başka bir biçime girme (Transformation).");
                break;
            case "diksiyon":
                Console.WriteLine("Diksiyon: Seslerin ve kelimelerin doğru ve etkili söylenme sanatı.");
                break;
            case "diplomasi":
                Console.WriteLine("Diplomasi: Uluslararası ilişkileri yürütme sanatı.");
                break;
            case "disiplin":
                Console.WriteLine("Disiplin: Kurallara bağlılık; bir bilim dalı.");
                break;
            case "distribütör":
                Console.WriteLine("Distribütör: Dağıtıcı; ürünleri pazarlayan aracı kuruluş.");
                break;
            case "divan":
                Console.WriteLine("Divan: Yüksek düzeydeki devlet adamlarının toplandığı meclis.");
                break;
            case "diğerkâm":
                Console.WriteLine("Diğerkâm: Kendi çıkarını düşünmeden başkalarına iyilik yapan.");
                break;
            case "doktrin":
                Console.WriteLine("Doktrin: Öğreti; bir konu hakkındaki görüşler bütünü.");
                break;
            case "doküman":
                Console.WriteLine("Doküman: Belge; bir durumu kanıtlayan yazılı kâğıt.");
                break;
            case "dolaylı":
                Console.WriteLine("Dolaylı: Aracı kullanarak yapılan, direkt olmayan.");
                break;
            case "dönemeç":
                Console.WriteLine("Dönemeç: Viraj; bir süreçteki kritik değişim noktası.");
                break;
            case "doruk":
                Console.WriteLine("Doruk: Zirve; bir şeyin en üst noktası.");
                break;
            case "dosya":
                Console.WriteLine("Dosya: Verilerin veya evrakların bir arada tutulduğu klasör.");
                break;
            case "dozaj":
                Console.WriteLine("Dozaj: Bir şeyin miktarını ayarlama, ölçü.");
                break;
            case "dramatik":
                Console.WriteLine("Dramatik: Etkileyici, heyecanlı veya acıklı durum.");
                break;
            case "düstur":
                Console.WriteLine("Düstur: Genel kural, ilke ve rehber alınan söz.");
                break;
            default:
                Console.WriteLine("Bilinmeyen kelime !");
                break;
        }
        break;

    case 'e':
    case 'E':
        Console.WriteLine("Kelime seçiniz. ( Ebedi, Ebat, Edinim, Efektif, Egemenlik, Ego, Eğilim, Ehil, Eklemleme, Ekol, Eksen, Eksper, Ekstrem, Elastik, Eleştiri, Elzem, Emanet, Emare, Empoze, Emsal, Ender, Endeks, Enerji, Envanter, Entegrasyon, Entite, Erdem, Erişim, Erozyon, Esas, Esneklik, Estetik, Eşzamanlı, Etap, Etik, Etken, Etki, Etkileşim, Etkin, Evrak, Evre, Evrim, Eylem, Ezber, Esas, Eşsiz, Etüt, Evrensel, Eyvallah, Enlem): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
           
        {
            case "ebedi":
                Console.WriteLine("Ebedi: Sonu olmayan, sonsuz, ölümsüz.");
                break;
            case "ebat":
                Console.WriteLine("Ebat: Boyutlar, bir şeyin eni, boyu ve derinliği.");
                break;
            case "edinim":
                Console.WriteLine("Edinim: Bir şeyi elde etme, kazanım (Acquisition).");
                break;
            case "efektif":
                Console.WriteLine("Efektif: Etkili, sonuç veren, gerçek anlamda kullanılan.");
                break;
            case "egemenlik":
                Console.WriteLine("Egemenlik: Yönetme gücü, hakimiyet, bağımsızlık.");
                break;
            case "ego":
                Console.WriteLine("Ego: Benlik, kişinin kendi kişiliği hakkındaki algısı.");
                break;
            case "eğilim":
                Console.WriteLine("Eğilim: Bir şeye duyulan ilgi veya yönelme (Trend).");
                break;
            case "ehil":
                Console.WriteLine("Ehil: Bir işin ustası olan, yetkili ve becerikli kişi.");
                break;
            case "eklemleme":
                Console.WriteLine("Eklemleme: Parçaları birbirine bağlama, ekleme yapma.");
                break;
            case "ekol":
                Console.WriteLine("Ekol: Bir bilim veya sanat dalındaki akım, okul.");
                break;
            case "eksen":
                Console.WriteLine("Eksen: Bir şeyin çevresinde döndüğü çizgi (Axis).");
                break;
            case "eksper":
                Console.WriteLine("Eksper: Bir konuda uzman olan, bilirkişi.");
                break;
            case "ekstrem":
                Console.WriteLine("Ekstrem: Aşırı, en uç noktada olan.");
                break;
            case "elastik":
                Console.WriteLine("Elastik: Esnek, şekil değiştirip eski haline dönebilen.");
                break;
            case "eleştiri":
                Console.WriteLine("Eleştiri: Bir eserin veya durumun iyi ve kötü yanlarını inceleme.");
                break;
            case "elzem":
                Console.WriteLine("Elzem: Çok gerekli, vazgeçilemez olan.");
                break;
            case "emanet":
                Console.WriteLine("Emanet: Korunması için birine bırakılan şey.");
                break;
            case "emare":
                Console.WriteLine("Emare: Belirti, iz, ipucu.");
                break;
            case "empoze":
                Console.WriteLine("Empoze: Zorla kabul ettirme, dayatma.");
                break;
            case "emsal":
                Console.WriteLine("Emsal: Benzer, örnek teşkil eden durum.");
                break;
            case "ender":
                Console.WriteLine("Ender: Çok seyrek görülen, az bulunan.");
                break;
            case "endeks":
                Console.WriteLine("Endeks: Bir değişkenin değişim oranını gösteren sayı dizisi.");
                break;
            case "enerji":
                Console.WriteLine("Enerji: İş yapabilme kapasitesi; canlılık.");
                break;
            case "envanter":
                Console.WriteLine("Envanter: Bir yerdeki malların veya varlıkların dökümü (Inventory).");
                break;
            case "entegrasyon":
                Console.WriteLine("Entegrasyon: Parçaların birleşerek bütünleşmesi (Integration).");
                break;
            case "entite":
                Console.WriteLine("Entite: Varlık; yazılımda veritabanı nesnesi (Entity).");
                break;
            case "erdem":
                Console.WriteLine("Erdem: Ahlaki açıdan üstün olma durumu, fazilet.");
                break;
            case "erişim":
                Console.WriteLine("Erişim: Bir şeye ulaşma, bağlantı kurma (Access).");
                break;
            case "erozyon":
                Console.WriteLine("Erozyon: Aşınma; mecazen değer kaybı.");
                break;
            case "esas":
                Console.WriteLine("Esas: Temel, kök, ana kural.");
                break;
            case "esneklik":
                Console.WriteLine("Esneklik: Şartlara uyum sağlama yeteneği (Flexibility).");
                break;
            case "estetik":
                Console.WriteLine("Estetik: Güzellik duygusuyla ilgili olan.");
                break;
            case "eşzamanlı":
                Console.WriteLine("Eşzamanlı: Aynı anda gerçekleşen (Synchronous).");
                break;
            case "etap":
                Console.WriteLine("Etap: Bir sürecin bölümlerinden her biri, aşama.");
                break;
            case "etik":
                Console.WriteLine("Etik: Ahlak felsefesi; doğru davranış kuralları.");
                break;
            case "etken":
                Console.WriteLine("Etken: Bir sonuca yol açan sebep, faktör.");
                break;
            case "etki":
                Console.WriteLine("Etki: Bir şeyin başka bir şey üzerinde bıraktığı iz (Impact).");
                break;
            case "etkileşim":
                Console.WriteLine("Etkileşim: Nesnelerin karşılıklı birbirini etkilemesi (Interaction).");
                break;
            case "etkin":
                Console.WriteLine("Etkin: Aktif olan, işleyen.");
                break;
            case "evrak":
                Console.WriteLine("Evrak: Resmi belgeler, kâğıtlar.");
                break;
            case "evre":
                Console.WriteLine("Evre: Bir sürecin belirli bir aşaması (Phase).");
                break;
            case "evrim":
                Console.WriteLine("Evrim: Zamanla meydana gelen değişim ve gelişim süreci.");
                break;
            case "eylem":
                Console.WriteLine("Eylem: Hareket, iş, aksiyon.");
                break;
            case "ezber":
                Console.WriteLine("Ezber: Bir bilgiyi zihne aynen yerleştirme.");
                break;
            case "enjeksiyon":
                Console.WriteLine("Enjeksiyon: Bir şeyi dışarıdan içeriye aktarma; yazılımda bağımlılıkların dışarıdan verilmesi (Injection).");
                break;
            case "eşsiz":
                Console.WriteLine("Eşsiz: Benzersiz, bir benzeri daha olmayan.");
                break;
            case "etüt":
                Console.WriteLine("Etüt: Bir konuyu derinlemesine inceleme, çalışma.");
                break;
            case "evrensel":
                Console.WriteLine("Evrensel: Tüm dünyayı kapsayan, genel.");
                break;
            case "eyvallah":
                Console.WriteLine("Eyvallah: Kabul etme, teşekkür veya veda ünlemi.");
                break;
            case "enlem":
                Console.WriteLine("Enlem: Yer küre üzerindeki paralel daireleri.");
                break;
        }
        break;

    case 'f':
    case 'F':
        Console.WriteLine("Kelime seçiniz. (Faaliyet, Fabl, Fahiş, Faktör, Fakülte, Fantezi, Farkındalık, Farklılık, Faset, Fasıla, Fayda, Faz, Feci, Fedakarlık, Federal, Fenomen, Feragat, Ferah, Feraset, Ferman, Fersah, Fert, Feryat, Fesat, Fetiş, Fetva, Feyz, Fihrist, Fiil, Fikir, Filoloji, Filtre, Final, Finans, Fira, Firar, Firkete, Firuze, Fiyat, Fizyoloji, Flora, Fluluk, Folklor, Fon, Fonksiyon, Form, Format, Formül, Forsa, Foya ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)

        {
            case "faaliyet":
                Console.WriteLine("Faaliyet: Bir amaca ulaşmak için yapılan iş, etkinlik, aksiyon.");
                break;
            case "fabl":
                Console.WriteLine("Fabl: Kahramanları genellikle hayvanlar olan, ders verici kısa öykü.");
                break;
            case "fahiş":
                Console.WriteLine("Fahiş: Ölçüyü aşan, çok fazla, aşırı (Genellikle fiyatlar için kullanılır).");
                break;
            case "faktör":
                Console.WriteLine("Faktör: Bir sonuca etki eden sebep, unsur veya etken.");
                break;
            case "fakülte":
                Console.WriteLine("Fakülte: Bir üniversitenin, benzer alanlarda eğitim veren akademik birimi.");
                break;
            case "fantezi":
                Console.WriteLine("Fantezi: Sonsuz hayal gücü; gerçek dışı sanatsal kurgu.");
                break;
            case "farkındalık":
                Console.WriteLine("Farkındalık: Bir durumun, olayın veya duygunun bilincinde olma.");
                break;
            case "farklılık":
                Console.WriteLine("Farklılık: İki şey arasındaki ayrım, benzer olmama durumu.");
                break;
            case "faset":
                Console.WriteLine("Faset: Bir nesnenin veya konunun farklı yönlerinden, yüzeylerinden her biri.");
                break;
            case "fasıla":
                Console.WriteLine("Fasıla: İki olay veya zaman dilimi arasındaki ara, kesinti.");
                break;
            case "fayda":
                Console.WriteLine("Fayda: Bir şeyin sağladığı yarar, kar veya iyilik.");
                break;
            case "faz":
                Console.WriteLine("Faz: Bir sürecin veya gelişimin aşamalarından her biri.");
                break;
            case "feci":
                Console.WriteLine("Feci: Çok acıklı, korkunç ve üzücü.");
                break;
            case "fedakarlık":
                Console.WriteLine("Fedakarlık: Bir amaç uğruna kendi çıkarlarından vazgeçme.");
                break;
            case "federal":
                Console.WriteLine("Federal: Birkaç devletin birleşerek oluşturduğu merkezi yönetim yapısı.");
                break;
            case "fenomen":
                Console.WriteLine("Fenomen: Gözlemlenebilen olay; mecazen büyük ilgi gören kişi veya durum.");
                break;
            case "feragat":
                Console.WriteLine("Feragat: Kendi isteğiyle bir haktan vazgeçme.");
                break;
            case "ferah":
                Console.WriteLine("Ferah: Bol, geniş, aydınlık; mecazen iç rahatlığı.");
                break;
            case "feraset":
                Console.WriteLine("Feraset: Anlayış, sezgi ve zihin uyanıklığı.");
                break;
            case "ferman":
                Console.WriteLine("Ferman: Osmanlı'da padişahın verdiği yazılı emir.");
                break;
            case "fersah":
                Console.WriteLine("Fersah: Yaklaşık 5-6 kilometrelik eski bir mesafe birimi.");
                break;
            case "fert":
                Console.WriteLine("Fert: Birey, toplumu oluşturan her bir kişi.");
                break;
            case "feryat":
                Console.WriteLine("Feryat: Acı ve korkuyla atılan yüksek sesli çığlık.");
                break;
            case "fesat":
                Console.WriteLine("Fesat: Karışıklık, bozukluk; mecazen hile ve ara bozma.");
                break;
            case "fetiş":
                Console.WriteLine("Fetiş: Tapınırcasına sevilen veya kutsal sayılan nesne.");
                break;
            case "fetva":
                Console.WriteLine("Fetva: Bir meselenin dinî kurala uygunluğunu bildiren görüş.");
                break;
            case "feyz":
                Console.WriteLine("Feyz: İlim ve irfan yönünden etkilenme, bereket alma.");
                break;
            case "fihrist":
                Console.WriteLine("Fihrist: İçindekiler listesi, dizin.");
                break;
            case "fiil":
                Console.WriteLine("Fiil: İş, oluş veya hareket bildiren kelime; eylem.");
                break;
            case "fikir":
                Console.WriteLine("Fikir: Düşünce, görüş, zihinde tasarlanan şey.");
                break;
            case "filoloji":
                Console.WriteLine("Filoloji: Dil bilimi; dillerin yapısını ve tarihini inceleyen bilim.");
                break;
            case "filtre":
                Console.WriteLine("Filtre: Süzgeç; verileri belirli kurallara göre ayıklayan araç.");
                break;
            case "final":
                Console.WriteLine("Final: Son, bitiş; bir sürecin en son aşaması.");
                break;
            case "finans":
                Console.WriteLine("Finans: Para yönetimi, sermaye sağlama ve yatırım işleri.");
                break;
            case "fira":
                Console.WriteLine("Fira: Eksilme, fire verme durumu.");
                break;
            case "firar":
                Console.WriteLine("Firar: Kaçma, bulunduğu yerden gizlice ayrılma.");
                break;
            case "firkete":
                Console.WriteLine("Firkete: U biçimindeki saç tokası.");
                break;
            case "firuze":
                Console.WriteLine("Firuze: Turkuaz renkli değerli bir taş.");
                break;
            case "fiyat":
                Console.WriteLine("Fiyat: Bir malın veya hizmetin para cinsinden değeri.");
                break;
            case "fizyoloji":
                Console.WriteLine("Fizyoloji: Canlıların organlarının işleyişini inceleyen bilim dalı.");
                break;
            case "flora":
                Console.WriteLine("Flora: Bir bölgedeki bitki örtüsünün tamamı.");
                break;
            case "fluluk":
                Console.WriteLine("Fluluk: Bulanıklık, net olmama durumu.");
                break;
            case "folklor":
                Console.WriteLine("Folklor: Halk bilimi; halkın gelenek ve göreneklerini inceler.");
                break;
            case "fon":
                Console.WriteLine("Fon: Belirli bir amaç için ayrılan para kaynağı; arka plan.");
                break;
            case "fonksiyon":
                Console.WriteLine("Fonksiyon: Belirli bir görevi yerine getiren işlem birimi (Function).");
                break;
            case "form":
                Console.WriteLine("Form: Şekil, biçim; veri girişi yapılan belge veya alan.");
                break;
            case "format":
                Console.WriteLine("Format: Genel düzen, biçim; bir diski kullanıma hazır hale getirme.");
                break;
            case "formül":
                Console.WriteLine("Formül: Bir kuralın simgelerle ifade edilmiş kısa yolu.");
                break;
            case "forsa":
                Console.WriteLine("Forsa: Eskiden gemilerde kürek çeken esir.");
                break;
            case "foya":
                Console.WriteLine("Foya: Mücevher arkasına konan metal; mecazen ortaya çıkan kusur.");
                break;
        }
        break;


    case 'g':
    case 'G':
        Console.WriteLine("Kelime seçiniz. ( Gafil, Galebe, Galeyan, Garabet, Garanti, Gayret, Gayri, Geveze, Geçerlilik, Gelenek, Gelişim, Genel, Genişleme, Gerçeklik, Gerekçe, Geribildirim, Gerilim, Girişim, Gizlilik, Global, Göç, Gövde, Gözlem, Grafik, Gramer, Grev, Grup, Gurur, Güvence, Güzergah, Güzide, Girdap, Girdi, Gişe, Görev, Görkem, Görsel, Görüş, Gösterge, Güdü, Gülünç, Güncel, Gündem, Güvenlik, Güzellik, Gardırop, Gaye, Geometri, Gıyabında, Göreli): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)

        {
            case "gafil":
                Console.WriteLine("Gafil: Çevresinde olup bitenlerin farkında olmayan, dalgın.");
                break;
            case "galebe":
                Console.WriteLine("Galebe: Üstün gelme, yenme, bozguna uğratma.");
                break;
            case "galeyan":
                Console.WriteLine("Galeyan: Coşma, kaynama; halkın büyük bir heyecanla ayaklanması.");
                break;
            case "garabet":
                Console.WriteLine("Garabet: Tuhaflık, gariplik, şaşılacak durum.");
                break;
            case "garanti":
                Console.WriteLine("Garanti: Bir işin sorumluluğunu üzerine alma, güvence.");
                break;
            case "gayret":
                Console.WriteLine("Gayret: Olağanüstü çalışma, çaba, azim.");
                break;
            case "gayri":
                Console.WriteLine("Gayri: Başka, özge; artık, bundan sonra.");
                break;
            case "geveze":
                Console.WriteLine("Geveze: Çok konuşan, boş konuşan kimse.");
                break;
            case "geçerlilik":
                Console.WriteLine("Geçerlilik: Bir kuralın veya belgenin yürürlükte olma durumu (Validity).");
                break;
            case "gelenek":
                Console.WriteLine("Gelenek: Bir toplumda eskiden kalma, kuşaktan kuşağa iletilen alışkanlıklar.");
                break;
            case "gelişim":
                Console.WriteLine("Gelişim: İlerleme, daha iyi bir duruma gelme süreci.");
                break;
            case "genel":
                Console.WriteLine("Genel: Bütünü kapsayan, ortak olan.");
                break;
            case "genişleme":
                Console.WriteLine("Genişleme: Bir alanın veya kapsamın büyümesi.");
                break;
            case "gerçeklik":
                Console.WriteLine("Gerçeklik: Var olan, hayal olmayan her şey (Reality).");
                break;
            case "gerekçe":
                Console.WriteLine("Gerekçe: Bir kararın veya işin dayandığı temel sebep.");
                break;
            case "geribildirim":
                Console.WriteLine("Geribildirim: Bir işlemin sonucuna dair yapılan bilgilendirme (Feedback).");
                break;
            case "gerilim":
                Console.WriteLine("Gerilim: İp veya telin gergin olma hali; mecazen huzursuzluk.");
                break;
            case "girişim":
                Console.WriteLine("Girişim: Bir işe başlamak için atılan adım, teşebbüs.");
                break;
            case "gizlilik":
                Console.WriteLine("Gizlilik: Bilginin yetkisiz kişilere kapalı olma durumu (Privacy).");
                break;
            case "global":
                Console.WriteLine("Global: Küresel, dünya çapında olan.");
                break;
            case "göç":
                Console.WriteLine("Göç: Bir yerleşim yerinden başka bir yere taşınma.");
                break;
            case "gövde":
                Console.WriteLine("Gövde: Bir nesnenin ana kısmı; yazılımda metodun içeriği (Body).");
                break;
            case "gözlem":
                Console.WriteLine("Gözlem: Bir olayı inceleyerek bilgi toplama süreci.");
                break;
            case "grafik":
                Console.WriteLine("Grafik: Verilerin çizgilerle veya şekillerle gösterilmesi.");
                break;
            case "gramer":
                Console.WriteLine("Gramer: Dil bilgisi kurallarının bütünü.");
                break;
            case "grev":
                Console.WriteLine("Grev: İşçilerin hak aramak için topluca iş bırakması.");
                break;
            case "grup":
                Console.WriteLine("Grup: Ortak özellikleri olan nesneler veya insanlar kümesi.");
                break;
            case "gurur":
                Console.WriteLine("Gurur: Öz saygı; bazen de kibir, kendini beğenme.");
                break;
            case "güvence":
                Console.WriteLine("Güvence: Bir sorumluluğun yerine getirileceğine dair verilen söz.");
                break;
            case "güzergah":
                Console.WriteLine("Güzergah: Yol boyu, izlenecek hat.");
                break;
            case "güzide":
                Console.WriteLine("Güzide: Seçkin, seçilmiş, üstün nitelikli.");
                break;
            case "girdap":
                Console.WriteLine("Girdap: Su anaforu; mecazen içinden çıkılması zor durum.");
                break;
            case "girdi":
                Console.WriteLine("Girdi: Bir sürece dahil edilen veri veya kaynak (Input).");
                break;
            case "gişe":
                Console.WriteLine("Gişe: Bilet veya işlem yapılan küçük pencere.");
                break;
            case "görev":
                Console.WriteLine("Görev: Bir kimsenin yapmakla yükümlü olduğu iş (Task).");
                break;
            case "görkem":
                Console.WriteLine("Görkem: Gösteriş, ihtişam, göz alıcılık.");
                break;
            case "görsel":
                Console.WriteLine("Görsel: Görme duyusuyla ilgili olan, resimsel.");
                break;
            case "görüş":
                Console.WriteLine("Görüş: Bir konu hakkındaki fikir veya bakış açısı.");
                break;
            case "gösterge":
                Console.WriteLine("Gösterge: Bir durumu belirtmeye yarayan araç (Indicator).");
                break;
            case "güdü":
                Console.WriteLine("Güdü: İnsanı harekete geçiren içsel dürtü (Motive).");
                break;
            case "gülünç":
                Console.WriteLine("Gülünç: Alay edilecek kadar saçma veya komik.");
                break;
            case "güncel":
                Console.WriteLine("Güncel: O anki zamanla ilgili, aktüel.");
                break;
            case "gündem":
                Console.WriteLine("Gündem: Toplantıda konuşulacak konuların listesi.");
                break;
            case "güvenlik":
                Console.WriteLine("Güvenlik: Tehlikelerden uzak olma durumu (Security).");
                break;
            case "güzellik":
                Console.WriteLine("Güzellik: Estetik olarak hoşa giden nitelik.");
                break;
            case "gardırop":
                Console.WriteLine("Gardırop: Elbise dolabı.");
                break;
            case "gaye":
                Console.WriteLine("Gaye: Amaç, hedef, ulaşılmak istenen sonuç.");
                break;
            case "geometri":
                Console.WriteLine("Geometri: Şekilleri ve boyutları inceleyen matematik dalı.");
                break;
            case "gıyabında":
                Console.WriteLine("Gıyabında: Kendi burada yokken, arkasından.");
                break;
            case "göreli":
                Console.WriteLine("Göreli: Kişiden kişiye değişen, rölatif.");
                break;
        }
        break;

    case 'h':
    case 'H':
        Console.WriteLine("Kelime seçiniz. ( Habis, Hafıza, Hafifletici, Hakkaniyet, Hakikat, Hakimiyet, Halel, Hamle, Handikap, Hareket, Hasar, Haslet, Hassasiyet, Hata, Hatıra, Havale, Hayat, Haysiyet, Hazine, Hedef, Hegemonya, Hekim, Hendese, Heves, Heyecan, Heyet, Hibe, Hiciv, Hidrolik, Hikaye, Hikmet, Hile, Himaye, Hipotez, His, Hisse, Hitabet, Hiyerarşi, Hizmet, Hizalama, Hodbin, Hukuk, Hurafe, Husus, Husumet, Huzur, Hücre, Hüküm, Hüner, Hürriyet): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)

        {
            case "habis":
                Console.WriteLine("Habis: Kötücül, alçak, zarar verici.");
                break;
            case "hafıza":
                Console.WriteLine("Hafıza: Yaşananları, öğrenilenleri akılda tutma gücü, bellek.");
                break;
            case "hafifletici":
                Console.WriteLine("Hafifletici: Bir suçun veya yükün ağırlığını azaltan sebep.");
                break;
            case "hakkaniyet":
                Console.WriteLine("Hakkaniyet: Doğruluk, dürüstlük ve adalete uygunluk.");
                break;
            case "hakikat":
                Console.WriteLine("Hakikat: Bir şeyin aslı, gerçek olan durum.");
                break;
            case "hakimiyet":
                Console.WriteLine("Hakimiyet: Egemenlik, bir yeri veya durumu yönetme gücü.");
                break;
            case "halel":
                Console.WriteLine("Halel: Bozma, eksiklik getirme, zarar verme.");
                break;
            case "hamle":
                Console.WriteLine("Hamle: İleriye doğru yapılan güçlü hareket, atılım.");
                break;
            case "handikap":
                Console.WriteLine("Handikap: Engel, dezavantajlı durum.");
                break;
            case "hareket":
                Console.WriteLine("Hareket: Durum değiştirme; bir amaca yönelik faaliyet.");
                break;
            case "hasar":
                Console.WriteLine("Hasar: Bir şeyde meydana gelen fiziksel zarar veya ziyan.");
                break;
            case "haslet":
                Console.WriteLine("Haslet: İnsanın yaradılışındaki güzel huy, özellik.");
                break;
            case "hassasiyet":
                Console.WriteLine("Hassasiyet: Duyarlılık, bir konudaki titizlik.");
                break;
            case "hata":
                Console.WriteLine("Hata: Yanlışlık, kusur; yazılımda 'bug' olarak adlandırılan durum.");
                break;
            case "hatıra":
                Console.WriteLine("Hatıra: Geçmişten kalan anı veya yadigâr.");
                break;
            case "havale":
                Console.WriteLine("Havale: Bir işi başkasına devretme; para gönderimi.");
                break;
            case "hayat":
                Console.WriteLine("Hayat: Canlılık, yaşam süreci.");
                break;
            case "haysiyet":
                Console.WriteLine("Haysiyet: Onur, öz saygı, kişinin kendine duyduğu değer.");
                break;
            case "hazine":
                Console.WriteLine("Hazine: Değerli eşyaların saklandığı yer; devlet kasası.");
                break;
            case "hedef":
                Console.WriteLine("Hedef: Ulaşılmak istenen amaç, gaye.");
                break;
            case "hegemonya":
                Console.WriteLine("Hegemonya: Bir devletin veya grubun diğerleri üzerindeki üstünlüğü.");
                break;
            case "hekim":
                Console.WriteLine("Hekim: Doktor, tıp doktoru.");
                break;
            case "hendese":
                Console.WriteLine("Hendese: Geometri; biçimleri ve ölçüleri inceleyen bilim.");
                break;
            case "heves":
                Console.WriteLine("Heves: Geçici istek, bir şeye karşı duyulan arzu.");
                break;
            case "heyecan":
                Console.WriteLine("Heyecan: Güçlü bir duygu yoğunluğuyla ortaya çıkan ruh hali.");
                break;
            case "heyet":
                Console.WriteLine("Heyet: Kurul, belirli bir amaç için toplanan kişiler topluluğu.");
                break;
            case "hibe":
                Console.WriteLine("Hibe: Bağış, bir malın karşılıksız devredilmesi.");
                break;
            case "hiciv":
                Console.WriteLine("Hiciv: Bir durumu veya kişiyi alaylı bir dille eleştirme.");
                break;
            case "hidrolik":
                Console.WriteLine("Hidrolik: Sıvıların mekanik özelliklerini inceleyen bilim dalı.");
                break;
            case "hikaye":
                Console.WriteLine("Hikaye: Gerçek veya kurgu olayların anlatılması; öykü.");
                break;
            case "hikmet":
                Console.WriteLine("Hikmet: Gizli sebep; bilgelik, derin anlam.");
                break;
            case "hile":
                Console.WriteLine("Hile: Aldatma, birini yanıltmak için yapılan oyun.");
                break;
            case "himaye":
                Console.WriteLine("Himaye: Koruma, gözetim altına alma.");
                break;
            case "hipotez":
                Console.WriteLine("Hipotez: Bir araştırmanın başlangıcında öne sürülen varsayım.");
                break;
            case "his":
                Console.WriteLine("His: Duygu, sezgi.");
                break;
            case "hisse":
                Console.WriteLine("Hisse: Pay, bir bütünden ayrılan kısım.");
                break;
            case "hitabet":
                Console.WriteLine("Hitabet: Topluluk önünde güzel ve etkileyici konuşma sanatı.");
                break;
            case "hiyerarşi":
                Console.WriteLine("Hiyerarşi: Makamların veya birimlerin alt-üst sıralaması.");
                break;
            case "hizmet":
                Console.WriteLine("Hizmet: Birinin işini görme; faydalı bir faaliyet sunma.");
                break;
            case "hizalama":
                Console.WriteLine("Hizalama: Nesneleri bir hat üzerine dizme (Alignment).");
                break;
            case "hodbin":
                Console.WriteLine("Hodbin: Sadece kendini düşünen, bencil.");
                break;
            case "hukuk":
                Console.WriteLine("Hukuk: Toplumu düzenleyen kurallar bütünü.");
                break;
            case "hurafe":
                Console.WriteLine("Hurafe: Akla aykırı, uydurma inanç.");
                break;
            case "husus":
                Console.WriteLine("Husus: Konu, özellik, bir şeyle ilgili ayrıntı.");
                break;
            case "husumet":
                Console.WriteLine("Husumet: Düşmanlık, birine karşı beslenen kötü duygu.");
                break;
            case "huzur":
                Console.WriteLine("Huzur: Rahatlık, dirlik, iç sakinliği.");
                break;
            case "hücre":
                Console.WriteLine("Hücre: Canlıların en küçük yapı birimi; küçük oda.");
                break;
            case "hüküm":
                Console.WriteLine("Hüküm: Karar, yargı; egemenlik.");
                break;
            case "hüner":
                Console.WriteLine("Hüner: Beceri, marifet, ustalık.");
                break;
            case "hürriyet":
                Console.WriteLine("Hürriyet: Özgürlük, bağımsız olma durumu.");
                break;
        }
        break;

    case 'ı':
    case 'I':
        Console.WriteLine("Kelime seçiniz. ( Iraksak, Irk, Islah, Isı, Israr, Istırap, Işık, Işıma, Itriyat, Iskarta, Iskonto, Issız, Istılah, Izgara, Ilık, Ilımlı, Irak, Irgat, Irmak, Ira, Işın, Ivır, Itır, Islık, Isıyayar, Isıölçer, Isıyalıtım, Issızlık, Işıklılık, Isınma, Islaklık, Irksal, Irkçılık, Israrcı, Islanma, Islahat, Istıranca, Ivırzıvır, Izdırap, Ikınma, Ipılık, Issızlaşma, Işıklandırma, Isıveren, Isıalan, Irgalama, Iraklık, Işıldak, Islak, Işıtma): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)

        {
            case "ıraksak":
                Console.WriteLine("Iraksak: Birbirinden uzaklaşan, ayrı yönlere giden (Divergent).");
                break;
            case "ırk":
                Console.WriteLine("Irk: Kalıtımsal olarak benzer özellikler taşıyan insan topluluğu.");
                break;
            case "ıslah":
                Console.WriteLine("Islah: İyileştirme, düzeltme, daha iyi bir duruma getirme.");
                break;
            case "ısı":
                Console.WriteLine("Isı: Bir enerjinin transfer biçimi; sıcaklık artışına neden olan güç.");
                break;
            case "ısrar":
                Console.WriteLine("Israr: Bir konuda ayak direme, üsteleme, vazgeçmeme.");
                break;
            case "ıstırap":
                Console.WriteLine("Istırap: Acı, keder, büyük ruhsal veya bedensel sancı.");
                break;
            case "ışık":
                Console.WriteLine("Işık: Görmeyi sağlayan fiziksel enerji; mecazen aydınlık fikir.");
                break;
            case "ışıma":
                Console.WriteLine("Işıma: Bir kaynaktan çıkan ışık dalgaları, radyasyon.");
                break;
            case "itriyat":
                Console.WriteLine("Itriyat: Güzel kokular, parfümeri işleri.");
                break;
            case "ıskarta":
                Console.WriteLine("Iskarta: Değersiz olduğu için ayrılan, kenara atılan parça.");
                break;
            case "ıskonto":
                Console.WriteLine("Iskonto: İndirim, bir fiyattan yapılan düşüş.");
                break;
            case "ıssız":
                Console.WriteLine("Issız: Kimsenin bulunmadığı, tenha ve sessiz yer.");
                break;
            case "ıstılah":
                Console.WriteLine("Istılah: Terim; belirli bir bilim veya sanat dalına ait özel kelime.");
                break;
            case "ızgara":
                Console.WriteLine("Izgara: Metal veya ağaçtan yapılmış kafesli düzenek.");
                break;
            case "ılık":
                Console.WriteLine("Ilık: Soğuk ile sıcak arası, hoş bir sıcaklık.");
                break;
            case "ılımlı":
                Console.WriteLine("Ilımlı: Aşırıya kaçmayan, ölçülü, mutedil.");
                break;
            case "ırak":
                Console.WriteLine("Irak: Uzak, mesafeli.");
                break;
            case "ırgat":
                Console.WriteLine("Irgat: Tarım işçisi; mecazen ağır iş yapan kişi.");
                break;
            case "ırmak":
                Console.WriteLine("Irmak: Akarsu, nehir.");
                break;
            case "ıra":
                Console.WriteLine("Ira: Karakter, bir şeyi diğerinden ayıran temel özellik.");
                break;
            case "ışın":
                Console.WriteLine("Işın: Bir kaynaktan çıkan tek yönlü ışık çizgisi.");
                break;
            case "ıvır":
                Console.WriteLine("Ivır: Değersiz, önemsiz şeyler (Genellikle 'zıvır' ile kullanılır).");
                break;
            case "ıtır":
                Console.WriteLine("Itır: Güzel koku, hoş kokulu bitki.");
                break;
            case "ıslık":
                Console.WriteLine("Islık: Dudak arasından çıkarılan keskin ses.");
                break;
            case "ısıyayar":
                Console.WriteLine("Isıyayar: Isıyı çevreye dağıtan cihaz, radyatör.");
                break;
            case "ısıölçer":
                Console.WriteLine("Isıölçer: Kalorimetre; ısı miktarını ölçen alet.");
                break;
            case "ısıyalıtım":
                Console.WriteLine("Isıyalıtım: Isı kaybını önlemek için yapılan işlem.");
                break;
            case "ıssızlık":
                Console.WriteLine("Issızlık: Tenhalık, kimsesizlik durumu.");
                break;
            case "ışıklılık":
                Console.WriteLine("Işıklılık: Bir yüzeyin yaydığı veya yansıttığı ışık miktarı.");
                break;
            case "ısınma":
                Console.WriteLine("Isınma: Sıcaklığın artması süreci; spora hazırlık evresi.");
                break;
            case "ıslaklık":
                Console.WriteLine("Islaklık: Bir yüzeyin sıvı ile kaplı olma durumu.");
                break;
            case "ırksal":
                Console.WriteLine("Irksal: Soyla veya ırkla ilgili olan.");
                break;
            case "ırkçılık":
                Console.WriteLine("Irkçılık: Bir ırkın diğerinden üstün olduğunu savunan görüş.");
                break;
            case "ısrarcı":
                Console.WriteLine("Israrcı: Bir konuda sürekli üsteleyen kişi.");
                break;
            case "ıslanma":
                Console.WriteLine("Islanma: Sıvı etkisiyle nemlenme veya su içinde kalma.");
                break;
            case "ıslahat":
                Console.WriteLine("Islahat: Toplumsal veya siyasi düzeltme hareketleri.");
                break;
            case "ıstıranca":
                Console.WriteLine("Istıranca: Balkanlar'da bir dağ sırası.");
                break;
            case "ıvırzıvır":
                Console.WriteLine("Ivırzıvır: Değersiz ve döküntü nesnelerin bütünü.");
                break;
            case "ızdırap":
                Console.WriteLine("Izdırap: Istırap kelimesinin yaygın ama ikincil yazımı; büyük acı.");
                break;
            case "ıkınma":
                Console.WriteLine("Ikınma: Güç sarf ederek soluğu tutma hareketi.");
                break;
            case "ıpılık":
                Console.WriteLine("Ipılık: Çok hoş ve tam kararında bir sıcaklık.");
                break;
            case "ıssızlaşma":
                Console.WriteLine("Issızlaşma: Bir yerin zamanla tenhalaşması.");
                break;
            case "ışıklandırma":
                Console.WriteLine("Işıklandırma: Bir yeri aydınlatma sistemi (Lighting).");
                break;
            case "ısıveren":
                Console.WriteLine("Isıveren: Etrafına ısı yayan (Ekzotermik).");
                break;
            case "ısıalan":
                Console.WriteLine("Isıalan: Dışarıdan ısı alan (Endotermik).");
                break;
            case "ırgalama":
                Console.WriteLine("Irgalama: Sarsma, yerinden oynatma.");
                break;
            case "ıraklık":
                Console.WriteLine("Iraklık: Uzaklık durumu; optikte odak mesafesi.");
                break;
            case "ışıldak":
                Console.WriteLine("Işıldak: Karanlıkta ışık yansıtan araç, projektör.");
                break;
            case "ıslak":
                Console.WriteLine("Islak: Üzerinde sıvı bulunan, nemli.");
                break;
            case "ışıtma":
                Console.WriteLine("Işıtma: Aydınlatma eylemi.");
                break;
        }
        break;


    case 'i':
    case 'İ':
        Console.WriteLine("Kelime seçiniz. ( İbraz, İcabet, İcra, İçerik, İdeal, İdrak, İfade, İflas, İhale, İhlal, İhracat, İhtimal, İhtiyat, İkilem, İklim, İkna, İkram, İktisat, İlave, İletişim, İlgi, İllüzyon, İlke, İmaj, İmkan, İmtiyaz, İndeks, İnovasyon, İnsiyatif, İntiba, İsabet, İskan, İstatistik, İstisna, İstihdam, İstihbarat, İstikrar, İtibar, İtimat, İtiraf, İvme, İzah, İzlenim, İzole, İçgüdü, İşlev, İşlemci, İştirak, İyileştirme, İzleyici ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "ibraz":
                Console.WriteLine("İbraz: Bir belgeyi veya kanıtı gösterme, sunma.");
                break;
            case "icabet":
                Console.WriteLine("İcabet: Bir çağrıya veya davete uyma, cevap verme.");
                break;
            case "icra":
                Console.WriteLine("İcra: Bir işi yapma, yürütme; borcun ödenmesi için yapılan yasal işlem.");
                break;
            case "içerik":
                Console.WriteLine("İçerik: Bir şeyin içinde bulunanların bütünü (Content).");
                break;
            case "ideal":
                Console.WriteLine("İdeal: Ulaşılmak istenen en yüksek hedef, mükemmel örnek.");
                break;
            case "idrak":
                Console.WriteLine("İdrak: Kavrama, anlama yeteneği, sezme.");
                break;
            case "ifade":
                Console.WriteLine("İfade: Duygu veya düşüncenin söz ya da yazı ile anlatılması.");
                break;
            case "iflas":
                Console.WriteLine("İflas: Bir işletmenin borçlarını ödeyemez duruma gelmesi.");
                break;
            case "ihale":
                Console.WriteLine("İhale: Bir işin veya malın en uygun teklifi verene bırakılması.");
                break;
            case "ihlal":
                Console.WriteLine("İhlal: Bir yasaya, kurala veya hakka uymama, bozma.");
                break;
            case "ihracat":
                Console.WriteLine("İhracat: Bir ülkenin ürettiği malları başka ülkelere satması (Export).");
                break;
            case "ihtimal":
                Console.WriteLine("İhtimal: Bir olayın gerçekleşme olasılığı.");
                break;
            case "ihtiyat":
                Console.WriteLine("İhtiyat: İleriyi düşünerek ölçülü ve tedbirli davranma.");
                break;
            case "ikilem":
                Console.WriteLine("İkilem: İki seçenek arasında karar verememe durumu (Dilemma).");
                break;
            case "iklim":
                Console.WriteLine("İklim: Bir bölgedeki uzun süreli hava olaylarının ortalaması.");
                break;
            case "ikna":
                Console.WriteLine("İkna: Birini bir düşünceye veya karara inandırma.");
                break;
            case "ikram":
                Console.WriteLine("İkram: Konuklara sunulan yiyecek, içecek veya gösterilen saygı.");
                break;
            case "iktisat":
                Console.WriteLine("İktisat: Ekonomi; sınırlı kaynakların yönetimini inceleyen bilim.");
                break;
            case "ilave":
                Console.WriteLine("İlave: Bir şeye eklenen parça, ek.");
                break;
            case "iletişim":
                Console.WriteLine("İletişim: Bilgi, duygu ve düşüncelerin karşılıklı aktarımı.");
                break;
            case "ilgi":
                Console.WriteLine("İlgi: Belirli bir şeye karşı duyulan merak veya yakınlık.");
                break;
            case "illüzyon":
                Console.WriteLine("İllüzyon: Göz yanılması; gerçek olmayanı varmış gibi görme.");
                break;
            case "ilke":
                Console.WriteLine("İlke: Temel kural, prensip.");
                break;
            case "imaj":
                Console.WriteLine("İmaj: Zihinde oluşturulan görüntü, izlenim.");
                break;
            case "imkan":
                Console.WriteLine("İmkan: Bir şeyin gerçekleşmesi için gerekli olan olanak.");
                break;
            case "imtiyaz":
                Console.WriteLine("İmtiyaz: Başkalarına tanınmayan özel hak, ayrıcalık.");
                break;
            case "indeks":
                Console.WriteLine("İndeks: Dizini; aranan bir veriye ulaşmayı kolaylaştıran liste.");
                break;
            case "inovasyon":
                Console.WriteLine("İnovasyon: Yenilikçilik; yeni ve yaratıcı fikirlerin uygulanması.");
                break;
            case "insiyatif":
                Console.WriteLine("İnsiyatif: Karar verme ve harekete geçme önceliği.");
                break;
            case "intiba":
                Console.WriteLine("İntiba: İzlenim; bir kişi veya durum hakkında edinilen ilk fikir.");
                break;
            case "isabet":
                Console.WriteLine("İsabet: Hedefi vurma; bir kararın tam yerinde olması.");
                break;
            case "iskan":
                Console.WriteLine("İskan: Bir yere yerleşme, yerleştirme.");
                break;
            case "istatistik":
                Console.WriteLine("İstatistik: Verilerin toplanması, analizi ve yorumlanması.");
                break;
            case "istisna":
                Console.WriteLine("İstisna: Kural dışı kalan durum.");
                break;
            case "istihdam":
                Console.WriteLine("İstihdam: İnsanların bir işte çalıştırılması.");
                break;
            case "istihbarat":
                Console.WriteLine("İstihbarat: Gizli toplanan bilgi ve haberler.");
                break;
            case "istikrar":
                Console.WriteLine("İstikrar: Kararlılık; bir durumun uzun süre değişmeden sürmesi.");
                break;
            case "itibar":
                Console.WriteLine("İtibar: Saygınlık, güvenilirlik.");
                break;
            case "itimat":
                Console.WriteLine("İtimat: Güvenme, inanma.");
                break;
            case "itiraf":
                Console.WriteLine("İtiraf: Gizli tutulan bir gerçeği açıklama.");
                break;
            case "ivme":
                Console.WriteLine("İvme: Hızın zamana göre değişim oranı (Acceleration).");
                break;
            case "izah":
                Console.WriteLine("İzah: Bir şeyi açıklama, anlaşılır kılma.");
                break;
            case "izlenim":
                Console.WriteLine("İzlenim: Bir şeyin ruh üzerinde bıraktığı etki (Impression).");
                break;
            case "izole":
                Console.WriteLine("İzole: Ayırılmış, yalıtılmış, tek başına bırakılmış.");
                break;
            case "içgüdü":
                Console.WriteLine("İçgüdü: Doğuştan gelen, öğrenilmemiş davranış eğilimi.");
                break;
            case "işlev":
                Console.WriteLine("İşlev: Bir şeyin gördüğü görev, fonksiyon.");
                break;
            case "işlemci":
                Console.WriteLine("İşlemci: Bilgisayarda verileri işleyen merkez birim (CPU).");
                break;
            case "iştirak":
                Console.WriteLine("İştirak: Ortak olma, bir işe katılma.");
                break;
            case "iyileştirme":
                Console.WriteLine("İyileştirme: Bir süreci veya durumu daha iyi hale getirme.");
                break;
            case "izleyici":
                Console.WriteLine("İzleyici: Bir gösteriyi veya olayı takip eden kişi.");
                break;
        }
        break;

    case 'j':
    case 'J':
        Console.WriteLine("Kelime seçiniz. ( Jakoben, Jale, Jandarma, Janjanlı, Jant, Jargon, Jartiyer, Jasp, Jel, Jelatin, Jenerasyon, Jeneratör, Jenerik, Jeofizik, Jeoloji, Jeomorfoloji, Jeopolitik, Jeotermal, Jest, Jeton, Jikle, Jimnastik, Jinekoloji, Jips, Joker, Jokey, Jön, Jöle, Jübile, Judocu, Judo, Jurnal, Jüri, Jurnalci, Jüpiter, Jura, Jön Türkler, Jelkot, Jakuzi, Jokeylik, Jambon, Jandarmalık, Janti, Japonya, Jar, Jeneriklik, Jerse, Jet, Jokey kulübü, Jul ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "jakoben":
                Console.WriteLine("Jakoben: Tepeden inmeci, sert ve tavizsiz bir şekilde bir görüşü dayatan kişi.");
                break;
            case "jale":
                Console.WriteLine("Jale: Çiçeklerin üzerine düşen su damlası, çiy.");
                break;
            case "jandarma":
                Console.WriteLine("Jandarma: Kamu düzenini korumakla görevli, askeri statüdeki güvenlik gücü.");
                break;
            case "janjanlı":
                Console.WriteLine("Janjanlı: Yanar dönerli renklere sahip olan, gösterişli.");
                break;
            case "jant":
                Console.WriteLine("Jant: Taşıtlarda lastiğin takıldığı tekerleğin metal kısmı.");
                break;
            case "jargon":
                Console.WriteLine("Jargon: Belirli bir meslek veya grup içindeki kişilerin kullandığı özel dil.");
                break;
            case "jartiyer":
                Console.WriteLine("Jartiyer: Çorapları tutmaya yarayan lastikli bağ.");
                break;
            case "jasp":
                Console.WriteLine("Jasp: Çizgili, benekli veya damarlı bir tür değerli taş.");
                break;
            case "jel":
                Console.WriteLine("Jel: Katı ile sıvı arasında, pelte kıvamındaki madde.");
                break;
            case "jelatin":
                Console.WriteLine("Jelatin: Hayvansal dokulardan elde edilen, gıda ve sanayide kullanılan yapışkan madde.");
                break;
            case "jenerasyon":
                Console.WriteLine("Jenerasyon: Aynı dönemde doğmuş ve benzer özellikler taşıyan kuşak.");
                break;
            case "jeneratör":
                Console.WriteLine("Jeneratör: Mekanik enerjiyi elektrik enerjisine dönüştüren cihaz.");
                break;
            case "jenerik":
                Console.WriteLine("Jenerik: Bir ürünün markasından ziyade türünü belirten genel isim; film başındaki tanıtım yazıları.");
                break;
            case "jeofizik":
                Console.WriteLine("Jeofizik: Yerin fiziksel özelliklerini inceleyen bilim dalı.");
                break;
            case "jeoloji":
                Console.WriteLine("Jeoloji: Yer bilim; dünyanın yapısını ve tarihini inceleyen bilim.");
                break;
            case "jeomorfoloji":
                Console.WriteLine("Jeomorfoloji: Yüzey şekillerini inceleyen coğrafya dalı.");
                break;
            case "jeopolitik":
                Console.WriteLine("Jeopolitik: Bir yerin coğrafi özelliklerinin siyaset üzerindeki etkisi.");
                break;
            case "jeotermal":
                Console.WriteLine("Jeotermal: Yerin derinliklerinden gelen sıcak su veya buhar gücü.");
                break;
            case "jest":
                Console.WriteLine("Jest: Duygu ve düşünceyi anlatmak için el, kol ve baş ile yapılan hareket.");
                break;
            case "jeton":
                Console.WriteLine("Jeton: Bazı otomatları çalıştırmak için kullanılan metal veya plastik para.");
                break;
            case "jikle":
                Console.WriteLine("Jikle: Motorlarda hava ve yakıt karışımını ayarlayan düzenek.");
                break;
            case "jimnastik":
                Console.WriteLine("Jimnastik: Çeviklik ve güç kazanmak için yapılan düzenli fiziksel hareketler.");
                break;
            case "jinekoloji":
                Console.WriteLine("Jinekoloji: Kadın hastalıklarını inceleyen tıp dalı.");
                break;
            case "jips":
                Console.WriteLine("Jips: Alçı taşı.");
                break;
            case "joker":
                Console.WriteLine("Joker: Oyunlarda her kağıdın yerine geçebilen kart; mecazen her işe yarayan çözüm.");
                break;
            case "jokey":
                Console.WriteLine("Jokey: Yarış atlarına binen profesyonel binici.");
                break;
            case "jön":
                Console.WriteLine("Jön: Tiyatro veya sinemada genç ve yakışıklı erkek başrol oyuncusu.");
                break;
            case "jöle":
                Console.WriteLine("Jöle: Donmuş meyve suyu veya saç şekillendirmek için kullanılan pelte.");
                break;
            case "jubile":
                Console.WriteLine("Jübile: Bir meslekteki (genellikle spor veya sanat) son büyük tören, veda.");
                break;
            case "judocu":
                Console.WriteLine("Judocu: Judo sporu ile uğraşan kişi.");
                break;
            case "judo":
                Console.WriteLine("Judo: Japon kökenli, silahsız yapılan bir savunma sporu.");
                break;
            case "jurnal":
                Console.WriteLine("Jurnal: Günlük; birini yetkililere şikayet etmek için verilen yazı.");
                break;
            case "juri":
                Console.WriteLine("Jüri: Seçici kurul, bir yarışmada kazananı belirleyen topluluk.");
                break;
            case "jurnalci":
                Console.WriteLine("Jurnalci: Haber taşıyan, birini başkasına kötüleyen kişi.");
                break;
            case "jüpiter":
                Console.WriteLine("Jüpiter: Güneş sistemindeki en büyük gezegen.");
                break;
            case "jura":
                Console.WriteLine("Jura: Jeolojik bir dönem; aynı zamanda Avrupa'da bir dağ sırası.");
                break;
            case "jön Türkler":
                Console.WriteLine("Jön Türkler: Osmanlı'da yenilikçi ve meşrutiyet yanlısı genç grup.");
                break;
            case "jelkot":
                Console.WriteLine("Jelkot: Kompozit malzemelerin dış yüzeyine parlaklık ve koruma sağlayan reçine.");
                break;
            case "jakuzi":
                Console.WriteLine("Jakuzi: Su fışkırtma özelliği olan banyo küveti.");
                break;
            case "jokeylik":
                Console.WriteLine("Jokeylik: Yarış atı biniciliği mesleği.");
                break;
            case "jambon":
                Console.WriteLine("Jambon: Tuzlanmış ve tütsülenmiş et.");
                break;
            case "jandarmalık":
                Console.WriteLine("Jandarmalık: Jandarma teşkilatının yaptığı görev.");
                break;
            case "janti":
                Console.WriteLine("Janti: Şık, zarif ve gösterişli giyinen.");
                break;
            case "japonya":
                Console.WriteLine("Japonya: Doğu Asya'da yer alan bir ada ülkesi.");
                break;
            case "jar":
                Console.WriteLine("Jar: Elektrik yükü biriktirmeye yarayan kap (Leyden kavanozu).");
                break;
            case "jeneriklik":
                Console.WriteLine("Jeneriklik: Sınıflandırılabilir veya türe özgü olma durumu.");
                break;
            case "jerse":
                Console.WriteLine("Jerse: Bir tür esnek örme kumaş.");
                break;
            case "jet":
                Console.WriteLine("Jet: Hızlı uçak; çok hızlı akan su veya hava akımı.");
                break;
            case "jokey kulübü":
                Console.WriteLine("Jokey Kulübü: At yarışlarını düzenleyen yetkili kurum.");
                break;
            case "jul":
                Console.WriteLine("Jul: Fizikte iş ve enerji birimi (Joule).");
                break;
        }
        break;

    case 'k':
    case 'K':
        Console.WriteLine("Kelime seçiniz. ( Kabiliyet, Kademe, Kafi, Kaos, Kapasite, Karar, Karakter, Kariyer, Karizma, Karmaşa, Kasti, Katalog, Kavram, Kaynak, Kazanım, Kelam, Kemiyet, Kenetleme, Kesinlik, Kesit, Keyfiyet, Kılavuz, Kıstas, Kıvam, Kimlik, Kip, Klasik, Koalisyon, Kod, Kolektif, Komut, Konferans, Konsept, Kontrol, Konu, Koordinasyon, Kopya, Korelasyon, Kozmik, Köken, Kritik, Kriter, Kriz, Kronoloji, Kural, Kuram, Kurgu, Kurul, Kurumsal, Küresel ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "kabiliyet":
                Console.WriteLine("Kabiliyet: Bir şeyi yapabilme becerisi, yetenek.");
                break;
            case "kademe":
                Console.WriteLine("Kademe: Bir süreçteki aşama veya rütbe sırası.");
                break;
            case "kafi":
                Console.WriteLine("Kafi: Yeterli, yeter miktarda olan.");
                break;
            case "kaos":
                Console.WriteLine("Kaos: Karmaşa, düzensizlik; evrenin düzene girmed önceki hali.");
                break;
            case "kapasite":
                Console.WriteLine("Kapasite: Bir şeyin içine alabileceği miktar veya bir kişinin iş yapabilme gücü.");
                break;
            case "karar":
                Console.WriteLine("Karar: Bir iş için verilen kesin sonuç, yargı.");
                break;
            case "karakter":
                Console.WriteLine("Karakter: Kişinin kendine özgü yapısı; yazılımda bir harf veya simge.");
                break;
            case "kariyer":
                Console.WriteLine("Kariyer: Bir meslekte zamanla elde edilen uzmanlık ve başarı süreci.");
                break;
            case "karizma":
                Console.WriteLine("Karizma: Etkileyici kişilik, büyüleyici güç.");
                break;
            case "karmaşa":
                Console.WriteLine("Karmaşa: Karışık olma durumu, kompleks yapı.");
                break;
            case "kasti":
                Console.WriteLine("Kasti: Bilerek, isteyerek yapılan.");
                break;
            case "katalog":
                Console.WriteLine("Katalog: Nesnelerin belirli bir sıraya göre dizildiği liste.");
                break;
            case "kavram":
                Console.WriteLine("Kavram: Bir nesnenin veya düşüncenin zihindeki genel tasarımı (Concept).");
                break;
            case "kaynak":
                Console.WriteLine("Kaynak: Bir şeyin çıktığı yer; üretim için gerekli olan varlık (Resource).");
                break;
            case "kazanım":
                Console.WriteLine("Kazanım: Bir süreç sonunda elde edilen değer veya bilgi.");
                break;
            case "kelam":
                Console.WriteLine("Kelam: Söz, konuşma.");
                break;
            case "kemiyet":
                Console.WriteLine("Kemiyet: Sayılabilen miktar, nicelik (Quantity).");
                break;
            case "kenetleme":
                Console.WriteLine("Kenetleme: Parçaları birbirine sıkıca bağlama.");
                break;
            case "kesinlik":
                Console.WriteLine("Kesinlik: Şüpheye yer bırakmayan doğruluk durumu.");
                break;
            case "kesit":
                Console.WriteLine("Kesit: Bir bütünün bir parçasını gösteren görünüş.");
                break;
            case "keyfiyet":
                Console.WriteLine("Keyfiyet: Bir şeyin nasıl olduğu, nitelik (Quality).");
                break;
            case "kılavuz":
                Console.WriteLine("Kılavuz: Yol gösteren, rehber; kullanım kitapçığı.");
                break;
            case "kıstas":
                Console.WriteLine("Kıstas: Ölçüt, bir şeyi değerlendirmek için kullanılan kural (Criteria).");
                break;
            case "kıvam":
                Console.WriteLine("Kıvam: Bir sıvının yoğunluk derecesi; tam olması gereken durum.");
                break;
            case "kimlik":
                Console.WriteLine("Kimlik: Birinin kim olduğunu belirten özelliklerin bütünü (Identity).");
                break;
            case "kip":
                Console.WriteLine("Kip: Fiillerde zaman ve anlam özelliğini belirten biçim.");
                break;
            case "klasik":
                Console.WriteLine("Klasik: Üzerinden zaman geçse de değerini kaybetmeyen, geleneksel.");
                break;
            case "koalisyon":
                Console.WriteLine("Koalisyon: Ortak bir amaç için kurulan geçici birlik.");
                break;
            case "kod":
                Console.WriteLine("Kod: Bilgisayara komut vermek için kullanılan simgeler bütünü.");
                break;
            case "kolektif":
                Console.WriteLine("Kolektif: Birçok kişinin bir araya gelerek oluşturduğu ortak yapı.");
                break;
            case "komut":
                Console.WriteLine("Komut: Bir işin yapılmasını emreden söz veya yazılım birimi.");
                break;
            case "konferans":
                Console.WriteLine("Konferans: Bilimsel veya sanatsal bir konuda yapılan toplu bilgilendirme.");
                break;
            case "konsept":
                Console.WriteLine("Konsept: Temel düşünce, anlayış veya tarz.");
                break;
            case "kontrol":
                Console.WriteLine("Kontrol: Denetleme, bir şeyin düzgün işleyip işlemediğini bakma.");
                break;
            case "konu":
                Console.WriteLine("Konu: Üzerinde konuşulan veya yazılan mesele.");
                break;
            case "koordinasyon":
                Console.WriteLine("Koordinasyon: Eşgüdüm; birimlerin uyum içinde çalışması.");
                break;
            case "kopya":
                Console.WriteLine("Kopya: Bir şeyin aynısı, örneği.");
                break;
            case "korelasyon":
                Console.WriteLine("Korelasyon: İki değişken arasındaki karşılıklı ilişki.");
                break;
            case "kozmik":
                Console.WriteLine("Kozmik: Evrenle, uzayla ilgili olan.");
                break;
            case "köken":
                Console.WriteLine("Köken: Bir şeyin dayandığı temel, başlangıç yeri.");
                break;
            case "kritik":
                Console.WriteLine("Kritik: Çok önemli, hayati; aynı zamanda eleştiri anlamında kullanılır.");
                break;
            case "kriter":
                Console.WriteLine("Kriter: Bir değerlendirme yaparken temel alınan ölçüt.");
                break;
            case "kriz":
                Console.WriteLine("Kriz: Beklenmedik, zor ve tehlikeli durum; çöküntü.");
                break;
            case "kronoloji":
                Console.WriteLine("Kronoloji: Olayların zaman sırasına göre dizilmesi.");
                break;
            case "kural":
                Console.WriteLine("Kural: Bir işin nasıl yapılması gerektiğini belirten ilke.");
                break;
            case "kuram":
                Console.WriteLine("Kuram: Teori; bir olayı açıklamak için öne sürülen sistemli fikirler.");
                break;
            case "kurgu":
                Console.WriteLine("Kurgu: Zihinde tasarlanan olaylar bütünü; montaj.");
                break;
            case "kurul":
                Console.WriteLine("Kurul: Belirli bir görevi yapmak üzere seçilmiş kişiler topluluğu.");
                break;
            case "kurumsal":
                Console.WriteLine("Kurumsal: Bir kuruma ait olan veya kurumun kimliğini yansıtan.");
                break;
            case "küresel":
                Console.WriteLine("Küresel: Tüm dünyayı kapsayan (Global).");
                break;
        }
        break;

    case 'l':
    case 'L':
        Console.WriteLine("Kelime seçiniz. ( Labil, Laboratuvar, Laçka, Ladin, Lafzen, Laiklik, Lakayıt, Lakap, Lakonizm, Lal, Lanse, Lastik, Latent, Latife, Lavabo, Layık, Lazım, Legal, Lejant, Lehtar, Lemur, Lenf, Levazım, Lezzet, Limit, Liman, Lineer, Lirik, Lisans, Liste, Literatür, Liyakat, Lobi, Log, Logaritma, Lojistik, Lokal, Lokasyon, Lop, Lonca, Loş, Lügat, Lüks, Lütuf, Lüzum, Lider, Liderlik, Libido, Likidite, Loop ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "labil":
                Console.WriteLine("Labil: Kararsız, değişken, dengesi çabuk bozulan.");
                break;
            case "laboratuvar":
                Console.WriteLine("Laboratuvar: Bilimsel araştırmaların ve deneylerin yapıldığı donanımlı yer.");
                break;
            case "laçka":
                Console.WriteLine("Laçka: Gevşemiş, düzeni bozulmuş, işleyemez hale gelmiş.");
                break;
            case "ladin":
                Console.WriteLine("Ladin: Çamgillerden, kerestesi değerli bir orman ağacı.");
                break;
            case "lafzen":
                Console.WriteLine("Lafzen: Sözle, kelimesi kelimesine (Yazılı olmayarak).");
                break;
            case "laiklik":
                Console.WriteLine("Laiklik: Din ve devlet işlerinin birbirinden ayrılması prensibi.");
                break;
            case "lakayıt":
                Console.WriteLine("Lakayıt: İlgisiz, aldırmaz, kayıtsız kalan.");
                break;
            case "lakap":
                Console.WriteLine("Lakap: Bir kimseye özelliklerine göre takılan takma ad.");
                break;
            case "lakonizm":
                Console.WriteLine("Lakonizm: Düşünceyi çok az kelimeyle, kısa ve öz anlatma sanatı.");
                break;
            case "lal":
                Console.WriteLine("Lal: Dili tutulmuş, konuşamaz hale gelmiş; parlak kırmızı renk.");
                break;
            case "lanse":
                Console.WriteLine("Lanse: Bir şeyi öne sürme, tanıtma veya piyasaya sunma.");
                break;
            case "lastik":
                Console.WriteLine("Lastik: Esnek, bükülebilen madde; otomobil tekerleği.");
                break;
            case "latent":
                Console.WriteLine("Latent: Gizli, henüz açığa çıkmamış (Örn: Gizli ısı veya belirti göstermeyen hastalık).");
                break;
            case "latife":
                Console.WriteLine("Latife: Şaka, güldürmek amacıyla söylenen ince söz.");
                break;
            case "lavabo":
                Console.WriteLine("Lavabo: El ve yüz yıkamaya yarayan, su tesisatlı düzenek.");
                break;
            case "layık":
                Console.WriteLine("Layık: Bir şeye hakkı olan, değer veya uygun görülen.");
                break;
            case "lazım":
                Console.WriteLine("Lazım: Gerekli, elzem olan.");
                break;
            case "legal":
                Console.WriteLine("Legal: Yasal, kanunlara uygun olan.");
                break;
            case "lejant":
                Console.WriteLine("Lejant: Harita veya planlarda kullanılan işaretlerin ne anlama geldiğini gösteren tablo.");
                break;
            case "lehtar":
                Console.WriteLine("Lehtar: Bir durumun veya kişinin tarafını tutan; senet veya çekin ödeneceği kişi.");
                break;
            case "lemur":
                Console.WriteLine("Lemur: Madagaskar'a özgü, iri gözlü bir primat türü.");
                break;
            case "lenf":
                Console.WriteLine("Lenf: Akkan; vücuttaki bağışıklık sistemine bağlı sıvı.");
                break;
            case "levazım":
                Console.WriteLine("Levazım: Bir iş veya kurum için gerekli olan araç, gereç ve malzeme.");
                break;
            case "lezzet":
                Console.WriteLine("Lezzet: Tad alma duyusuyla algılanan hoşluk; mecazen keyif.");
                break;
            case "limit":
                Console.WriteLine("Limit: Sınır, uç nokta; matematikte bir değişkenin yaklaştığı değer.");
                break;
            case "liman":
                Console.WriteLine("Liman: Gemilerin barındığı, yükleme yaptığı korunaklı yer.");
                break;
            case "lineer":
                Console.WriteLine("Lineer: Doğrusal; bir çizgi boyunca ilerleyen (Linear).");
                break;
            case " lirik":
                Console.WriteLine("Lirik: Coşkulu, içten gelen duyguları anlatan sanat eseri.");
                break;
            case "lisans":
                Console.WriteLine("Lisans: Bir işi yapma yetkisi; dört yıllık üniversite derecesi.");
                break;
            case "liste":
                Console.WriteLine("Liste: Alt alta yazılmış nesneler veya isimler dizisi.");
                break;
            case "literatür":
                Console.WriteLine("Literatür: Bir bilim dalındaki yazılı eserlerin bütünü, kaynakça.");
                break;
            case "liyakat":
                Console.WriteLine("Liyakat: Bir işe uygunluk, yaraşırlık, beceri ve başarı düzeyi.");
                break;
            case "lobi":
                Console.WriteLine("Lobi: Otel girişi; mecazen bir karar organını etkilemek için yapılan kulis faaliyeti.");
                break;
            case "log":
                Console.WriteLine("Log: Günlük; sistemde meydana gelen olayların tarihsel kaydı.");
                break;
            case "logaritma":
                Console.WriteLine("Logaritma: Üstel fonksiyonun tersi olan matematiksel işlem.");
                break;
            case "lojistik":
                Console.WriteLine("Lojistik: Ürün ve hizmetlerin ihtiyaç duyulan yere zamanında ulaştırılması süreci.");
                break;
            case "lokal":
                Console.WriteLine("Lokal: Yerel, belirli bir bölgeyle sınırlı olan.");
                break;
            case "lokasyon":
                Console.WriteLine("Lokasyon: Bir nesnenin veya yerin konumu (Location).");
                break;
            case "lop":
                Console.WriteLine("Lop: Bir organın (akciğer, beyin vb.) yuvarlak ve belirgin parçası.");
                break;
            case "lonca":
                Console.WriteLine("Lonca: Orta Çağ'da aynı işi yapan esnafların kurduğu dayanışma örgütü.");
                break;
            case "loş":
                Console.WriteLine("Loş: Yeterince aydınlık olmayan, hafif karanlık.");
                break;
            case "lügat":
                Console.WriteLine("Lügat: Sözlük; bir dildeki kelimelerin bütünü.");
                break;
            case "lüks":
                Console.WriteLine("Lüks: İhtiyaç dışı, aşırı konforlu ve gösterişli olan.");
                break;
            case "lütuf":
                Console.WriteLine("Lütuf: İyilik, bağış, birinden gelen hoşgörü veya yardım.");
                break;
            case "lüzum":
                Console.WriteLine("Lüzum: Gereklilik, ihtiyaç duyma.");
                break;
            case "lider":
                Console.WriteLine("Lider: Bir grubu yöneten, vizyon sahibi ve etkileyici kişi.");
                break;
            case "liderlik":
                Console.WriteLine("Liderlik: İnsanları belirli bir amaca doğru yönlendirme ve etkileme yeteneği.");
                break;
            case "libido":
                Console.WriteLine("Libido: Yaşama gücü, temel içsel enerji.");
                break;
            case "likidite":
                Console.WriteLine("Likidite: Bir varlığın hızlıca nakit paraya dönüştürülebilme yeteneği.");
                break;
            case "loop":
                Console.WriteLine("Loop: Yazılımda belirli bir işlemin tekrarlanmasını sağlayan döngü yapısı.");
                break;
        }
        break;

    case 'm':
    case 'M':
        Console.WriteLine("Kelime seçiniz. ( Madde, Mafya, Mahal, Maharet, Mahiyet, Mahrem, Mahsul, Makul, Maliyet, Manevra, Manidar, Mantık, Marj, Marifet, Maske, Masraf, Matematik, Materyal, Matris, Mazeret, Meblağ, Mecburiyet, Mecra, Medeni, Meleke, Menfaat, Menkul, Merci, Merhamet, Mesai, Mesafe, Mesuliyet, Metafor, Metot, Mevki, Mevzuat, Mizah, Mizan, Mobil, Model, Modern, Modül, Monitör, Motive, Motivasyon, Muadil, Muamele, Muazzam, Müdahale, Mülkiyet ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "madde":
                Console.WriteLine("Madde: Boşlukta yer kaplayan, kütlesi olan varlık; yasa fıkrası.");
                break;
            case "mafya":
                Console.WriteLine("Mafya: Yasa dışı işlerle uğraşan, gizli ve hiyerarşik örgüt.");
                break;
            case "mahal":
                Console.WriteLine("Mahal: Yer, yöre, bir olayın gerçekleştiği bölge.");
                break;
            case "maharet":
                Console.WriteLine("Maharet: El yatkınlığı, ustalık, beceri.");
                break;
            case "mahiyet":
                Console.WriteLine("Mahiyet: Bir şeyin aslı, esası, iç yüzü ve niteliği.");
                break;
            case "mahrem":
                Console.WriteLine("Mahrem: Gizli kalması gereken, herkese anlatılmayan özel durum.");
                break;
            case "mahsul":
                Console.WriteLine("Mahsul: Ürün, verim; bir çalışmanın sonucu.");
                break;
            case "makul":
                Console.WriteLine("Makul: Akla uygun, mantıklı, kabul edilebilir.");
                break;
            case "maliyet":
                Console.WriteLine("Maliyet: Bir mal veya hizmetin elde edilmesi için harcanan değerlerin toplamı.");
                break;
            case "manevra":
                Console.WriteLine("Manevra: Bir amaca ulaşmak için yapılan ustaca hareket veya taktik.");
                break;
            case "manidar":
                Console.WriteLine("Manidar: Anlamlı, derin bir anlam taşıyan, imalı.");
                break;
            case "mantık":
                Console.WriteLine("Mantık: Doğru düşünme kurallarını inceleyen bilim; yazılımda 'logic'.");
                break;
            case "marj":
                Console.WriteLine("Marj: Pay, sınır; iki değer arasındaki fark (Örn: Kar marjı).");
                break;
            case "marifet":
                Console.WriteLine("Marifet: Beceri, ustalık; herkesin yapamadığı özel iş.");
                break;
            case "maske":
                Console.WriteLine("Maske: Yüzü gizlemek için kullanılan araç; mecazen gerçek duyguları saklama.");
                break;
            case "masraf":
                Console.WriteLine("Masraf: Harcanan para, gider.");
                break;
            case "matematik":
                Console.WriteLine("Matematik: Sayıları ve şekilleri inceleyen temel bilim dalı.");
                break;
            case "materyal":
                Console.WriteLine("Materyal: Malzeme, bir iş için gerekli olan araç gereç.");
                break;
            case "matris":
                Console.WriteLine("Matris: Sayıların satır ve sütunlar şeklinde düzenlenmiş hali.");
                break;
            case "mazeret":
                Console.WriteLine("Mazeret: Bir kusurun veya eksikliğin kabul edilebilir sebebi.");
                break;
            case "meblağ":
                Console.WriteLine("Meblağ: Para tutarı, belirli bir miktar para.");
                break;
            case "mecburiyet":
                Console.WriteLine("Mecburiyet: Zorunluluk, yapmak zorunda olma durumu.");
                break;
            case "mecra":
                Console.WriteLine("Mecra: Akış yeri, kanal; mecazen bir işin ilerlediği yol veya ortam.");
                break;
            case "medeni":
                Console.WriteLine("Medeni: Uygar, toplum kurallarına uyan, nazik.");
                break;
            case "meleke":
                Console.WriteLine("Meleke: Alışkanlıkla kazanılan beceri, yatkınlık.");
                break;
            case "menfaat":
                Console.WriteLine("Menfaat: Çıkar, yarar, kişisel kazanç.");
                break;
            case "menkul":
                Console.WriteLine("Menkul: Taşınabilen mal veya varlık.");
                break;
            case "merci":
                Console.WriteLine("Merci: Başvurulacak makam, yetkili yer.");
                break;
            case "merhamet":
                Console.WriteLine("Merhamet: Acıma duygusu, şefkat gösterme.");
                break;
            case "mesai":
                Console.WriteLine("Mesai: Çalışma süresi, emek harcanan zaman.");
                break;
            case "mesafe":
                Console.WriteLine("Mesafe: İki nokta arasındaki uzaklık; mecazen resmiyet.");
                break;
            case "mesuliyet":
                Console.WriteLine("Mesuliyet: Sorumluluk, bir işin sonucunu üstlenme.");
                break;
            case "metafor":
                Console.WriteLine("Metafor: Mecaz; bir kavramı başka bir şeyle benzerlik kurarak anlatma.");
                break;
            case "metot":
                Console.WriteLine("Metot: Yöntem; bir amaca ulaşmak için izlenen sistemli yol.");
                break;
            case "mevki":
                Console.WriteLine("Mevki: Yer, konum; makam ve rütbe.");
                break;
            case "mevzuat":
                Console.WriteLine("Mevzuat: Bir alandaki yasaların, yönetmeliklerin ve kuralların bütünü.");
                break;
            case "mizah":
                Console.WriteLine("Mizah: Gülmece; olayların komik ve düşündürücü yönlerini ortaya koyma.");
                break;
            case "mizan":
                Console.WriteLine("Mizan: Terazi; muhasebede hesapların kontrolünü sağlayan cetvel.");
                break;
            case "mobil":
                Console.WriteLine("Mobil: Hareketli, taşınabilir; akıllı cihaz teknolojisi.");
                break;
            case "model":
                Console.WriteLine("Model: Örnek, kalıp; bir sistemin basitleştirilmiş tasarımı.");
                break;
            case "modern":
                Console.WriteLine("Modern: Çağdaş, güncel, zamana uygun.");
                break;
            case "modül":
                Console.WriteLine("Modül: Bir bütünü oluşturan bağımsız parçalardan her biri.");
                break;
            case "monitör":
                Console.WriteLine("Monitör: Ekran; sistemdeki verileri izlemeye yarayan cihaz.");
                break;
            case "motive":
                Console.WriteLine("Motive: Bir işi yapmak için içsel veya dışsal itici güç, güdü.");
                break;
            case "motivasyon":
                Console.WriteLine("Motivasyon: Bir amacı gerçekleştirmek için gereken isteklilik hali.");
                break;
            case "muadil":
                Console.WriteLine("Muadil: Eş değer, karşılık gelen, benzer.");
                break;
            case "muamele":
                Console.WriteLine("Muamele: Davranış biçimi; resmi makamlardaki işlem.");
                break;
            case "muazzam":
                Console.WriteLine("Muazzam: Çok büyük, devasa, hayranlık uyandıracak kadar görkemli.");
                break;
            case "müdahale":
                Console.WriteLine("Müdahale: Karışma, bir olayın akışını değiştirmek için araya girme.");
                break;
            case "mülkiyet":
                Console.WriteLine("Mülkiyet: Sahiplik, bir varlık üzerinde hak sahibi olma.");
                break;
        }
        break;

    case 'n':
    case 'N':
        Console.WriteLine("Kelime seçiniz. ( Nabız, Nadir, Naif, Nakit, Nakil, Nalları dikmek, Namus, Nankör, Narin, Nasip, Nasihat, Navigasyon, Nazariyat, Nazik, Nedamet, Neden, Nefes, Nefret, Negatif, Nem, Nesil, Nesne, Nesnel, Net, Network, Nezaket, Nicelik, Nihai, Nimet, Nispet, Nitelik, Niyet, Nizam, Node, Nominal, Norm, Normal, Nostalji, Not, Noter, Nötr, Nüans, Nüfus, Nüfuz, Null, Numara, Numune, Nutuk, Nüsha, Nükte ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "nabız":
                Console.WriteLine("Nabız: Kalp atışının damarlarda hissedilmesi; mecazen bir topluluğun eğilimi.");
                break;
            case "nadir":
                Console.WriteLine("Nadir: Çok seyrek görülen, az bulunan, kıymetli.");
                break;
            case "naif":
                Console.WriteLine("Naif: Saf, deneyimsiz, doğal ve içten davranan.");
                break;
            case "nakit":
                Console.WriteLine("Nakit: Para, hemen harcanabilir durumdaki ödeme aracı.");
                break;
            case "nakil":
                Console.WriteLine("Nakil: Bir şeyi bir yerden başka bir yere aktarma, taşıma.");
                break;
            case "nalları dikmek":
                Console.WriteLine("Nalları dikmek: (Deyim) Argo bir ifadeyle ölmek.");
                break;
            case "namus":
                Console.WriteLine("Namus: Toplum içindeki ahlaki değerlere bağlılık, onur.");
                break;
            case "nankör":
                Console.WriteLine("Nankör: Gördüğü iyiliğin değerini bilmeyen, iyilik bilmez.");
                break;
            case "narin":
                Console.WriteLine("Narin: İnce, nazik, çabuk kırılabilen veya zarar görebilen.");
                break;
            case "nasip":
                Console.WriteLine("Nasip: Birinin payına düşen şey, kısmet.");
                break;
            case "nasihat":
                Console.WriteLine("Nasihat: Öğüt, doğru yolu göstermek için söylenen söz.");
                break;
            case "navigasyon":
                Console.WriteLine("Navigasyon: Yol bulma; bir yerden bir yere gitmek için kullanılan sistem.");
                break;
            case "nazariyat":
                Console.WriteLine("Nazariyat: Kuramlar bütünü, teoriler.");
                break;
            case "nazik":
                Console.WriteLine("Nazik: Saygılı, ince davranışlı; dikkatle ele alınması gereken.");
                break;
            case "nedamet":
                Console.WriteLine("Nedamet: Pişmanlık, yapılan bir işten duyulan üzüntü.");
                break;
            case "neden":
                Console.WriteLine("Neden: Bir şeyi doğuran sebep, faktör.");
                break;
            case "nefes":
                Console.WriteLine("Nefes: Soluk; mecazen dinlenme payı, mola.");
                break;
            case "nefret":
                Console.WriteLine("Nefret: Birine veya bir şeye karşı duyulan aşırı tiksinti ve düşmanlık.");
                break;
            case "negatif":
                Console.WriteLine("Negatif: Olumsuz; matematikte sıfırdan küçük değer.");
                break;
            case "nem":
                Console.WriteLine("Nem: Hava veya nesnelerin içindeki su buharı, rutubet.");
                break;
            case "nesil":
                Console.WriteLine("Nesil: Aynı dönemde doğmuş insanların bütünü, kuşak.");
                break;
            case "nesne":
                Console.WriteLine("Nesne: Elle tutulur varlık; yazılımda veriyi ve metotları barındıran yapı (Object).");
                break;
            case "nesnel":
                Console.WriteLine("Nesnel: Kişisel duygulardan bağımsız, tarafsız (Objective).");
                break;
            case "net":
                Console.WriteLine("Net: Açık, belirgin; kesintiler çıktıktan sonra kalan miktar.");
                break;
            case "network":
                Console.WriteLine("Network: Bilgisayarların veya insanların oluşturduğu bağlantı ağı.");
                break;
            case "nezaket":
                Console.WriteLine("Nezaket: İncelik, görgü kurallarına uygun davranma.");
                break;
            case "nicelik":
                Console.WriteLine("Nicelik: Sayılabilen, ölçülebilen özellik (Quantity).");
                break;
            case "nihai":
                Console.WriteLine("Nihai: Sonuncu, en son ulaşılan karar veya aşama.");
                break;
            case "nimet":
                Console.WriteLine("Nimet: İyilik, lütuf, faydalanılan güzel şey.");
                break;
            case "nispet":
                Console.WriteLine("Nispet: Oran, iki şey arasındaki bağıntı.");
                break;
            case "nitelik":
                Console.WriteLine("Nitelik: Bir şeyi diğerinden ayıran özellik, kalite (Quality).");
                break;
            case "niyet":
                Console.WriteLine("Niyet: Bir şeyi yapmayı önceden tasarlama, amaç.");
                break;
            case "nizam":
                Console.WriteLine("Nizam: Düzen, kural, yasalara uygunluk.");
                break;
            case "node":
                Console.WriteLine("Node: Bağlantı noktası; veri yapılarında her bir eleman.");
                break;
            case "nominal":
                Console.WriteLine("Nominal: İtibari, kağıt üzerinde görünen değer.");
                break;
            case "norm":
                Console.WriteLine("Norm: Kural; toplumsal veya teknik olarak kabul edilen standart.");
                break;
            case "normal":
                Console.WriteLine("Normal: Alışılagelmiş, kurala uyan, beklenen.");
                break;
            case "nostalji":
                Console.WriteLine("Nostalji: Geçmişe duyulan özlem.");
                break;
            case "not":
                Console.WriteLine("Not: Hatırlatıcı kısa yazı; başarıyı gösteren puan.");
                break;
            case "noter":
                Console.WriteLine("Noter: Belgeleri resmileştiren ve onaylayan yetkili makam.");
                break;
            case "nötr":
                Console.WriteLine("Nötr: Tarafsız; elektrikte yüksüz olan.");
                break;
            case "nüans":
                Console.WriteLine("Nüans: İnce ayrıntı, küçük fark.");
                break;
            case "nüfus":
                Console.WriteLine("Nüfus: Bir bölgede yaşayan insan sayısı.");
                break;
            case "nüfuz":
                Console.WriteLine("Nüfuz: İçine işleme, etkileme gücü.");
                break;
            case "null":
                Console.WriteLine("Null: Boş, tanımsız; yazılımda bir değerin olmadığını belirten ifade.");
                break;
            case "numara":
                Console.WriteLine("Numara: Sayısal işaret; mecazen hile, oyun.");
                break;
            case "numune":
                Console.WriteLine("Numune: Örnek, bir şeyin özelliklerini gösteren küçük parça.");
                break;
            case "nutuk":
                Console.WriteLine("Nutuk: Topluluk önünde yapılan etkileyici konuşma.");
                break;
            case "nüsha":
                Console.WriteLine("Nüsha: Bir belgenin kopyası olan her bir tek parça.");
                break;
            case "nükte":
                Console.WriteLine("Nükte: İnce, anlamlı ve güldüren söz.");
                break;
        }
        break;


    case 'o':
    case 'O':
        Console.WriteLine("Kelime seçiniz. ( Odak, Olanak, Olgu, Olasılık, Onay, Operasyon, Optimizasyon, Opsiyon, Oran, Ordinat, Organizasyon, Organize, Org, Oryantasyon, Otomasyon, Otonom, Otorite, Objektif, Obje, Ofis, Ofsayt, Okul, Oksijen, Oktan, Okunaklı, Olgunluk, Olumlu, Oluşum, Omurga, Onur, Onarım, Operator, Oportünist, Optik, Oral, Ordulama, Organik, Orgeneral, Orijinal, Orkestra, Orta, Ortaklık, Ortam, Ortodox, Otantik, Otobiyografi, Otokrasi, Oturum, Oylama, Ozon ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "odak":
                Console.WriteLine("Odak: Bir ışık demetinin toplandığı nokta; mecazen ilginin toplandığı yer (Focus).");
                break;
            case "olanak":
                Console.WriteLine("Olanak: Bir şeyin gerçekleşmesini sağlayan şartlar, imkan.");
                break;
            case "olgu":
                Console.WriteLine("Olgu: Varlığı deneyle kanıtlanmış olan, gerçekleşmiş olay (Fact).");
                break;
            case "olasılık":
                Console.WriteLine("Olasılık: Bir olayın gerçekleşme şansı, ihtimal (Probability).");
                break;
            case "onay":
                Console.WriteLine("Onay: Bir kararı veya durumu kabul etme, tasdik.");
                break;
            case "operasyon":
                Console.WriteLine("Operasyon: Belirli bir amaca yönelik yürütülen işlerin bütünü, harekat.");
                break;
            case "optimizasyon":
                Console.WriteLine("Optimizasyon: Bir sistemin en verimli şekilde çalışmasını sağlama süreci.");
                break;
            case "opsiyon":
                Console.WriteLine("Opsiyon: Seçenek, tercih hakkı.");
                break;
            case "oran":
                Console.WriteLine("Oran: İki miktar arasındaki sayısal bağıntı, nispet.");
                break;
            case "ordinat":
                Console.WriteLine("Ordinat: Koordinat düzleminde dikey eksen (Y ekseni).");
                break;
            case "organizasyon":
                Console.WriteLine("Organizasyon: Düzenli bir amaç için bir araya gelmiş yapı veya topluluk.");
                break;
            case "organize":
                Console.WriteLine("Organize: Düzenlenmiş, iş birliği içinde hareket eden.");
                break;
            case "org":
                Console.WriteLine("Org: Bir kurumun veya canlının yapısal birimi; aynı zamanda bir çalgı.");
                break;
            case "oryantasyon":
                Console.WriteLine("Oryantasyon: Yeni bir duruma veya işe alıştırma süreci, yönlendirme.");
                break;
            case "otomasyon":
                Console.WriteLine("Otomasyon: İşlerin insan müdahalesi olmadan makinelerle yürütülmesi.");
                break;
            case "otonom":
                Console.WriteLine("Otonom: Kendi kendini yönetebilen, özerk.");
                break;
            case "otorite":
                Console.WriteLine("Otorite: Yaptırım gücü olan kişi veya kurum, yetke.");
                break;
            case "objektif":
                Console.WriteLine("Objektif: Nesnel, tarafsız bakış açısı; fotoğraf makinesi merceği.");
                break;
            case "obje":
                Console.WriteLine("Obje: Nesne; yazılımda hafızada yer kaplayan veri yapısı (Object).");
                break;
            case "ofis":
                Console.WriteLine("Ofis: İş yeri, büro.");
                break;
            case "ofsayt":
                Console.WriteLine("Ofsayt: Futbolda bir kural; mecazen zamansız veya yanlış hareket.");
                break;
            case "okul":
                Console.WriteLine("Okul: Eğitim ve öğretim verilen kurum; ekol.");
                break;
            case "oksijen":
                Console.WriteLine("Oksijen: Yaşam için gerekli temel gaz element.");
                break;
            case "oktan":
                Console.WriteLine("Oktan: Yakıtın vuruntuya karşı direncini gösteren ölçü.");
                break;
            case "okunaklı":
                Console.WriteLine("Okunaklı: Kolayca okunabilen yazı veya kod.");
                break;
            case "olgunluk":
                Console.WriteLine("Olgunluk: Gelişimini tamamlamış olma durumu (Maturity).");
                break;
            case "olumlu":
                Console.WriteLine("Olumlu: Pozitif, yapıcı, iyi sonuç veren.");
                break;
            case "oluşum":
                Console.WriteLine("Oluşum: Meydana gelme süreci, teşekkül.");
                break;
            case "omurga":
                Console.WriteLine("Omurga: Ana iskelet yapısı; bir projenin en temel bölümü.");
                break;
            case "onur":
                Console.WriteLine("Onur: Öz saygı, şeref, haysiyet.");
                break;
            case "onarım":
                Console.WriteLine("Onarım: Bozulan bir şeyi tekrar çalışır hale getirme (Repair).");
                break;
            case "operator":
                Console.WriteLine("Operator: Bir makineyi veya sistemi kullanan kişi; yazılımda işlem simgesi.");
                break;
            case "oportünist":
                Console.WriteLine("Oportünist: Koşulları kendi çıkarı için kullanan, fırsatçı.");
                break;
            case "optik":
                Console.WriteLine("Optik: Işık ve görme olaylarını inceleyen bilim.");
                break;
            case "oral":
                Console.WriteLine("Oral: Sözlü, ağız yoluyla yapılan.");
                break;
            case "ordulama":
                Console.WriteLine("Ordulama: Sıralama, düzene koyma.");
                break;
            case "organik":
                Console.WriteLine("Organik: Doğal yollarla oluşan; canlı dokuyla ilgili.");
                break;
            case "orgeneral":
                Console.WriteLine("Orgeneral: Kara ve hava kuvvetlerinde en yüksek rütbeli subay.");
                break;
            case "orijinal":
                Console.WriteLine("Orijinal: Özgün, taklit olmayan, ilk elden.");
                break;
            case "orkestra":
                Console.WriteLine("Orkestra: Birçok çalgının birlikte çaldığı büyük müzik topluluğu.");
                break;
            case "orta":
                Console.WriteLine("Orta: İki uç arasındaki merkez; mecazen ölçülü.");
                break;
            case "ortaklık":
                Console.WriteLine("Ortaklık: Bir işi birlikte yürütmek üzere kurulan bağ (Partnership).");
                break;
            case "ortam":
                Console.WriteLine("Ortam: Canlıların içinde bulunduğu koşullar; yazılımda 'environment'.");
                break;
            case "ortodox":
                Console.WriteLine("Ortodox: Genel kabul görmüş kurallara sıkı sıkıya bağlı.");
                break;
            case "otantik":
                Console.WriteLine("Otantik: Gerçek, aslına uygun, yapay olmayan.");
                break;
            case "otobiyografi":
                Console.WriteLine("Otobiyografi: Bir kişinin kendi yaşam öyküsünü yazması.");
                break;
            case "otokrasi":
                Console.WriteLine("Otokrasi: Tek bir yöneticinin sınırsız yetkiye sahip olduğu yönetim biçimi.");
                break;
            case "oturum":
                Console.WriteLine("Oturum: Bir toplantının her bir bölümü; yazılımda 'session'.");
                break;
            case "oylama":
                Console.WriteLine("Oylama: Bir kararı belirlemek için oy kullanma işlemi.");
                break;
            case "ozon":
                Console.WriteLine("Ozon: Atmosferin üst katmanlarında bulunan koruyucu gaz tabakası.");
                break;
        }
        break;

    case 'ö':
    case 'Ö':
        Console.WriteLine("Kelime seçiniz. ( Öbek, Öngörü, Ödün, Ödül, Ödeme, Ödünç, Öge, Öğreti, Öğrenim, Ölçüt, Ölçek, Ömür, Öncelik, Öncü, Önder, Öneri, Önlem, Önsezi, Önemsiz, Öngörülemez, Önişlemci, Önbellek, Önerme, Önyargı, Öpmek, Örf, Örgüt, Örnek, Örselemek, Örtüşmek, Örüntü, Öte, Ötelenme, Övgü, Övünç, Öykü, Öykünme, Özel, Özen, Özerk, Özet, Özgün, Özgürlük, Özne, Özveri, Özetleme, Özle, Özdeş, Özyineleme, Öz ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "öbek":
                Console.WriteLine("Öbek: Birbirine benzeyen veya aynı yerde bulunan nesneler topluluğu, küme.");
                break;
            case "öngörü":
                Console.WriteLine("Öngörü: Bir işin ileride alacağı hali önceden tahmin etme yetisi (Foresight).");
                break;
            case "ödün":
                Console.WriteLine("Ödün: Bir anlaşmaya varmak için kendi isteklerinden vazgeçme, taviz.");
                break;
            case "ödül":
                Console.WriteLine("Ödül: Bir başarı karşılığında verilen armağan veya takdir.");
                break;
            case "ödeme":
                Console.WriteLine("Ödeme: Bir borcun veya hizmet bedelinin kapatılması işlemi.");
                break;
            case "ödünç":
                Console.WriteLine("Ödünç: Geri verilmek üzere alınan veya verilen şey.");
                break;
            case "öge":
                Console.WriteLine("Öge: Bir bütünü oluşturan temel parçalardan her biri (Element).");
                break;
            case "öğreti":
                Console.WriteLine("Öğreti: Bir bilim veya sanat dalındaki görüşlerin bütünü, doktrin.");
                break;
            case "öğrenim":
                Console.WriteLine("Öğrenim: Bir okulda veya kurs sonunda edinilen bilgi ve deneyim.");
                break;
            case "ölçüt":
                Console.WriteLine("Ölçüt: Bir şeyi değerlendirmek için kullanılan kural veya kıstas (Criterion).");
                break;
            case "ölçek":
                Console.WriteLine("Ölçek: Bir harita veya çizimdeki küçültme oranı; değerlendirme aracı (Scale).");
                break;
            case "ömür":
                Console.WriteLine("Ömür: Yaşam süresi; bir sistemin veya canlının aktif kalma müddeti.");
                break;
            case "öncelik":
                Console.WriteLine("Öncelik: Sıralamada veya önemde diğerlerinden önde olma durumu (Priority).");
                break;
            case "öncü":
                Console.WriteLine("Öncü: Bir akımı veya hareketi ilk başlatan, yol gösteren kişi.");
                break;
            case "önder":
                Console.WriteLine("Önder: Bir topluluğa rehberlik eden, onları yöneten kişi.");
                break;
            case "öneri":
                Console.WriteLine("Öneri: Bir sorunu çözmek için öne sürülen teklif veya tavsiye.");
                break;
            case "önlem":
                Console.WriteLine("Önlem: Kötü bir durumu önlemek için alınan tedbir.");
                break;
            case "önsezi":
                Console.WriteLine("Önsezi: Bir şeyin olacağını hiçbir kanıt yokken hissetme.");
                break;
            case "önemsiz":
                Console.WriteLine("Önemsiz: Dikkate değer olmayan, cüzi miktar veya değer.");
                break;
            case "öngörülemez":
                Console.WriteLine("Öngörülemez: Tahmin edilmesi mümkün olmayan durum.");
                break;
            case "önişlemci":
                Console.WriteLine("Önişlemci: Yazılımda ana kod çalışmadan önce hazırlık yapan birim (Preprocessor).");
                break;
            case "önbellek":
                Console.WriteLine("Önbellek: Verilerin hızlı erişim için geçici olarak saklandığı yer (Cache).");
                break;
            case "önerme":
                Console.WriteLine("Önerme: Doğruluğu veya yanlışlığı tartışılabilen temel yargı.");
                break;
            case "önyargı":
                Console.WriteLine("Önyargı: Bir kimse veya durumla ilgili peşin hüküm verme.");
                break;
            case "öpmek":
                Console.WriteLine("Öpmek: Sevgi göstergesi olarak dudakla yapılan temas.");
                break;
            case "örf":
                Console.WriteLine("Örf: Toplumda yasalaşmamış ancak kabul görmüş geleneksel kurallar.");
                break;
            case "örgüt":
                Console.WriteLine("Örgüt: Ortak bir amaç için bir araya gelmiş kurum veya topluluk.");
                break;
            case "örnek":
                Console.WriteLine("Örnek: Bir şeyin özelliklerini yansıtan benzeri (Sample/Example).");
                break;
            case "örselemek":
                Console.WriteLine("Örselemek: Bir şeyi hırpalamak, yıpratmak veya etkisini azaltmak.");
                break;
            case "örtüşmek":
                Console.WriteLine("Örtüşmek: İki durumun birbirine tam olarak uyması, çakışması.");
                break;
            case "örüntü":
                Console.WriteLine("Örüntü: Belirli bir kurala göre tekrarlayan yapı (Pattern).");
                break;
            case "öte":
                Console.WriteLine("Öte: Bir şeyin daha ilerisinde olan yer veya durum.");
                break;
            case "ötelenme":
                Console.WriteLine("Ötelenme: Bir nesnenin bir yerden başka bir yere kaydırılması.");
                break;
            case "övgü":
                Console.WriteLine("Övgü: Birinin başarısını veya niteliğini yücelten söz.");
                break;
            case "övünç":
                Console.WriteLine("Övünç: Başarıdan duyulan gurur ve sevinç.");
                break;
            case "öykü":
                Console.WriteLine("Öykü: Gerçek veya tasarlanmış olayların anlatıldığı kısa yazı, hikaye.");
                break;
            case "öykünme":
                Console.WriteLine("Öykünme: Birine veya bir şeye benzemeye çalışma, taklit etme.");
                break;
            case "özel":
                Console.WriteLine("Özel: Sadece bir kişiye veya duruma ait olan, şahsi (Private).");
                break;
            case "özen":
                Console.WriteLine("Özen: Bir işin kusursuz olması için gösterilen titizlik.");
                break;
            case "özerk":
                Console.WriteLine("Özerk: Kendi kendini yönetme yetkisi olan, otonom.");
                break;
            case "özet":
                Console.WriteLine("Özet: Bir konunun ana hatlarını içeren kısa anlatım.");
                break;
            case "özgün":
                Console.WriteLine("Özgün: Taklit olmayan, sadece kendine has nitelikleri olan (Original).");
                break;
            case "özgürlük":
                Console.WriteLine("Özgürlük: Herhangi bir dış zorlama olmadan karar verme yetisi.");
                break;
            case "özne":
                Console.WriteLine("Özne: Bir eylemi gerçekleştiren varlık; yazılımda temel yapı taşı.");
                break;
            case "özveri":
                Console.WriteLine("Özveri: Bir amaç uğruna kendi çıkarlarından vazgeçme, fedakarlık.");
                break;
            case "özetleme":
                Console.WriteLine("Özetleme: Bilgiyi en yalın ve vurucu haliyle sunma işlemi.");
                break;
            case "özle":
                Console.WriteLine("Özle: Bir şeye veya birine duyulan hasret.");
                break;
            case "özdeş":
                Console.WriteLine("Özdeş: Her bakımdan birbiriyle aynı olan (Identical).");
                break;
            case "özyineleme":
                Console.WriteLine("Özyineleme: Yazılımda bir fonksiyonun kendi kendini çağırması (Recursion).");
                break;
            case "öz":
                Console.WriteLine("Öz: Bir şeyin en temel ve değişmez kısmı, cevheri.");
                break;
        }
        break;

    case 'p':
    case 'P':
        Console.WriteLine("Kelime seçiniz. ( Paha, Paket, Pakt, Panzehir, Paradigma, Paradoks, Paragraf, Paralel, Parametre, Parite, Parola, Parti, Pasif, Patent, Paydaş, Pazarlama, Pekiştirme, Performans, Periyodik, Perspektif, Prensip, Prestij, Prim, Priorite, Prizma, Prosedür, Proses, Prodüktivite, Profesyonel, Profil, Program, Proje, Projeksiyon, Promosyon, Propaganda, Prostat, Protokol, Prototip, Provokasyon, Puan, Pusula, Pürüz, Platform, Paylaşım, Planlama, Politik, Potansiyel, Pratik, Pres, Pointer ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "paha":
                Console.WriteLine("Paha: Bir şeyin para ile ölçülen değeri, fiyat.");
                break;
            case "paket":
                Console.WriteLine("Paket: Birbirine bağlı parçalar bütünü; yazılımda kütüphane birimi (Package).");
                break;
            case "pakt":
                Console.WriteLine("Pakt: Devletler veya gruplar arasında yapılan resmi antlaşma, bağlaşma.");
                break;
            case "panzehir":
                Console.WriteLine("Panzehir: Zehrin etkisini yok eden madde; mecazen bir soruna bulunan kesin çözüm.");
                break;
            case "paradigma":
                Console.WriteLine("Paradigma: Bir bilim dalının veya düşünce yapısının temel model ve değerleri.");
                break;
            case "paradoks":
                Console.WriteLine("Paradoks: Aykırı düşünce; görünüşte çelişkili ama aslında doğru olabilen durum.");
                break;
            case "paragraf":
                Console.WriteLine("Paragraf: Bir yazının kendi içinde bütünlük taşıyan her bir bölümü.");
                break;
            case "paralel":
                Console.WriteLine("Paralel: Birbirine hiç kesişmeden uzanan; yazılımda aynı anda yürütülen işlemler.");
                break;
            case "parametre":
                Console.WriteLine("Parametre: Bir fonksiyonun veya sistemin dışarıdan aldığı değişken değer.");
                break;
            case "parite":
                Console.WriteLine("Parite: İki farklı para biriminin birbirine oranı veya eşitliği.");
                break;
            case "parola":
                Console.WriteLine("Parola: Bir yere veya sisteme girmek için kullanılan gizli kelime (Password).");
                break;
            case "parti":
                Console.WriteLine("Parti: Siyasi veya toplumsal grup; belirli bir miktar mal topluluğu.");
                break;
            case "pasif":
                Console.WriteLine("Pasif: Etkin olmayan, çekingen, bir etkiye karşı tepki vermeyen.");
                break;
            case "patent":
                Console.WriteLine("Patent: Bir buluşun kullanım hakkının sadece buluş sahibine ait olduğunu gösteren belge.");
                break;
            case "paydaş":
                Console.WriteLine("Paydaş: Bir projede veya kurumda menfaati veya katkısı olan tüm taraflar (Stakeholder).");
                break;
            case "pazarlama":
                Console.WriteLine("Pazarlama: Ürünlerin tüketicilere ulaştırılması için yapılan planlama ve tanıtım süreci.");
                break;
            case "pekiştirme":
                Console.WriteLine("Pekiştirme: Bir bilgiyi veya durumu daha sağlam ve kalıcı hale getirme.");
                break;
            case "performans":
                Console.WriteLine("Performans: Bir işin yapılma hızı, verimliliği ve kalitesi.");
                break;
            case "periyodik":
                Console.WriteLine("Periyodik: Belirli zaman aralıklarıyla tekrarlanan.");
                break;
            case "perspektif":
                Console.WriteLine("Perspektif: Bakış açısı; nesnelerin uzaktan görünüş derinliği.");
                break;
            case "prensip":
                Console.WriteLine("Prensip: Temel kural, ilke, vazgeçilmeyen tutum.");
                break;
            case "prestij":
                Console.WriteLine("Prestij: Saygınlık, itibar, bir kişinin veya kurumun toplumdaki ağırlığı.");
                break;
            case "prim":
                Console.WriteLine("Prim: Bir başarı karşılığında ödenen ek ücret; sigorta ödemesi.");
                break;
            case "priorite":
                Console.WriteLine("Priorite: Öncelik, bir işin diğerlerinden önce yapılması gerekliliği.");
                break;
            case "prizma":
                Console.WriteLine("Prizma: Işığı renklerine ayıran geometrik şekil; mecazen farklı değerlendirme yönü.");
                break;
            case "prosedür":
                Console.WriteLine("Prosedür: Bir işin yapılması için izlenmesi gereken resmi yöntem ve adımlar.");
                break;
            case "proses":
                Console.WriteLine("Proses: Bir ürünün elde edilmesi için geçen süreçlerin bütünü.");
                break;
            case "prodüktivite":
                Console.WriteLine("Prodüktivite: Verimlilik; girdilerin çıktılara oranı.");
                break;
            case "profesyonel":
                Console.WriteLine("Profesyonel: Bir işi kazanç sağlamak amacıyla ve ustalıkla yapan kişi.");
                break;
            case "profil":
                Console.WriteLine("Profil: Bir kişinin veya nesnenin yandan görünüşü; temel özellikler listesi.");
                break;
            case "program":
                Console.WriteLine("Program: Belirli bir sıraya göre yapılması tasarlanan işler dizisi; yazılım.");
                break;
            case "proje":
                Console.WriteLine("Proje: Belirli bir sürede ve bütçede bir amaca ulaşmak için hazırlanan plan.");
                break;
            case "projeksiyon":
                Console.WriteLine("Projeksiyon: Bir görüntüyü bir yüzeye yansıtma; geleceğe yönelik tahmin yapma.");
                break;
            case "promosyon":
                Console.WriteLine("Promosyon: Satışları artırmak için yapılan özendirme çalışması, tanıtım.");
                break;
    case "propaganda":
                Console.WriteLine("Propaganda: Bir düşünceyi yaymak için yapılan sistematik çalışma.");
                break;
            case "prostat":
                Console.WriteLine("Prostat: Erkek üreme sisteminde bulunan bir salgı bezi.");
                break;
            case "protokol":
                Console.WriteLine("Protokol: Resmi ilişkilerde uygulanan kurallar; yazılımda veri değişim kuralları.");
                break;
            case "prototip":
                Console.WriteLine("Prototip: Bir ürünün seri üretime geçmeden önceki ilk ve örnek hali.");
                break;
            case "provokasyon":
                Console.WriteLine("Provokasyon: Kışkırtma, birini kötü bir iş yapmaya zorlayacak davranış.");
                break;
            case "puan":
                Console.WriteLine("Puan: Bir başarıyı ölçmek için kullanılan sayısal değer.");
                break;
            case "pusula":
                Console.WriteLine("Pusula: Yön bulmaya yarayan araç; mecazen rehber alınan temel ilke.");
                break;
            case "pürüz":
                Console.WriteLine("Pürüz: Bir yüzeydeki pürüzlülük; mecazen bir işteki engel veya kusur.");
                break;
            case "platform":
                Console.WriteLine("Platform: Uygulamaların üzerinde çalıştığı temel yapı (İşletim sistemi vb.).");
                break;
            case "paylaşım":
                Console.WriteLine("Paylaşım: Bir varlığı veya bilgiyi başkalarıyla ortak kullanma.");
                break;
            case "planlama":
                Console.WriteLine("Planlama: Gelecekte yapılacak işlerin bir takvime ve kurala bağlanması.");
                break;
            case "politik":
                Console.WriteLine("Politik: Siyasetle ilgili; mecazen amaca ulaşmak için izlenen yol.");
                break;
            case "potansiyel":
                Console.WriteLine("Potansiyel: Henüz ortaya çıkmamış ama var olan güç veya imkan.");
                break;
            case "pratik":
                Console.WriteLine("Pratik: Uygulamaya dayalı olan, kolay ve kullanışlı.");
                break;
            case "pres":
                Console.WriteLine("Pres: Baskı makinesi; mecazen birini karar vermeye zorlama.");
                break;
            case "pointer":
                Console.WriteLine("Pointer: Yazılımda bellekteki bir adresi gösteren işaretçi değişken.");
                break;
        }
        break;

    case 'r':
    case 'R':
        Console.WriteLine("Kelime seçiniz. ( Radikal, Rağbet, Rahatlık, Rakip, Rakam, Randıman, Rapor, Rassal, Rastlantı, Rasyonel, Rayiç, Reaksiyon, Realite, Refah, Referans, Reform, Regresyon, Rehber, Rehin, Rekabet, Reklam, Rekor, Rektör, Remi, Renovasyon, Rant, Replika, Repo, Repository, Resmi, Restorasyon, Revaç, Revize, Rezerve, Rezidans, Ritim, Risk, Robotik, Rol, Romantik, Rota, Rutin, Rütbe, Rüya, Rüşvet, Runtime, Recursive, Refactoring, Response, Rendering ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "radikal":
                Console.WriteLine("Radikal: Köklü, kesin ve kökten değişimi hedefleyen.");
                break;
            case "rağbet":
                Console.WriteLine("Rağbet: Bir şeye duyulan aşırı ilgi, istek ve talep.");
                break;
            case "rahatlık":
                Console.WriteLine("Rahatlık: Sıkıntı ve zorlama olmama durumu, konfor.");
                break;
            case "rakip":
                Console.WriteLine("Rakip: Aynı amaca ulaşmaya çalışan diğer taraf, yarışmacı.");
                break;
            case "rakam":
                Console.WriteLine("Rakam: Sayıları göstermek için kullanılan on simgeden her biri.");
                break;
            case "randıman":
                Console.WriteLine("Randıman: Verim; bir çalışmadan elde edilen fayda oranı.");
                break;
            case "rapor":
                Console.WriteLine("Rapor: Yapılan bir çalışmanın sonucunu bildiren resmi yazı.");
                break;
            case "rassal":
                Console.WriteLine("Rassal: Rastgele, belirli bir kurala bağlı olmadan gerçekleşen (Random).");
                break;
            case "rastlantı":
                Console.WriteLine("Rastlantı: Bilgi ve hazırlık olmaksızın gelişen olay, tesadüf.");
                break;
            case "rasyonel":
                Console.WriteLine("Rasyonel: Akla dayalı, mantıklı, ölçülü.");
                break;
            case "rayiç":
                Console.WriteLine("Rayiç: Bir malın o günkü piyasa değeri, sürüm değeri.");
                break;
            case "reaksiyon":
                Console.WriteLine("Reaksiyon: Bir etkiye karşı verilen tepki; kimyasal tepkime.");
                break;
            case "realite":
                Console.WriteLine("Realite: Gerçeklik; varsayım olmayan, var olan durum.");
                break;
            case "refah":
                Console.WriteLine("Refah: Bolluk ve huzur içinde yaşama durumu.");
                break;
            case "referans":
                Console.WriteLine("Referans: Kaynak gösterme; bir kişinin veya kurumun güvenilirliğini kanıtlayan belge.");
                break;
            case "reform":
                Console.WriteLine("Reform: Bir kurumun veya sistemin daha iyi hale getirilmesi için yapılan düzeltme.");
                break;
            case "regresyon":
                Console.WriteLine("Regresyon: Geriye gitme; veri biliminde değişkenler arası ilişkiyi ölçen analiz.");
                break;
            case "rehber":
                Console.WriteLine("Rehber: Yol gösteren kişi veya kılavuz kitap.");
                break;
            case "rehin":
                Console.WriteLine("Rehin: Bir borca karşılık güvence olarak verilen değerli eşya.");
                break;
            case "rekabet":
                Console.WriteLine("Rekabet: Aynı amaca ulaşmak için başkalarıyla yarışma durumu.");
                break;
            case "reklam":
                Console.WriteLine("Reklam: Bir ürünü veya fikri tanıtmak için yapılan duyuru çalışmaları.");
                break;
            case "rekor":
                Console.WriteLine("Rekor: Bir alanda ulaşılan en yüksek sonuç veya başarı düzeyi.");
                break;
            case "rektör":
                Console.WriteLine("Rektör: Bir üniversitenin en üst düzey yöneticisi.");
                break;
            case "remi":
                Console.WriteLine("Remi: Beraberlik; bir yarışın veya maçın eşit sonuçlanması.");
                break;
            case "renovasyon":
                Console.WriteLine("Renovasyon: Yenileme, eski bir yapıyı onararak tekrar kullanılır hale getirme.");
                break;
            case "rant":
                Console.WriteLine("Rant: Bir malın üretim yapılmaksızın sağladığı gelir.");
                break;
            case "replika":
                Console.WriteLine("Replika: Bir eserin aslına uygun yapılmış kopyası.");
                break;
            case "repo":
                Console.WriteLine("Repo: Bir kıymetli evrakın belli bir süre sonra geri alınmak üzere satılması.");
                break;
            case "repository":
                Console.WriteLine("Repository: Yazılımda kodların ve verilerin saklandığı depo, ambar.");
                break;
            case "resmi":
                Console.WriteLine("Resmi: Devlete veya bir makama ait olan, ciddiyet taşıyan.");
                break;
            case "restorasyon":
                Console.WriteLine("Restorasyon: Tarihi bir eserin aslına uygun olarak onarılması.");
                break;
            case "revaç":
                Console.WriteLine("Revaç: Bir şeyin sürümde olması, çok aranması.");
                break;
            case "revize":
                Console.WriteLine("Revize: Gözden geçirilerek düzeltme, yenileme (Revision).");
                break;
            case "rezerve":
                Console.WriteLine("Rezerve: Bir yeri veya şeyi önceden ayırma.");
                break;
            case "rezidans":
                Console.WriteLine("Rezidans: Yüksek konforlu konut yapısı.");
                break;
            case "ritim":
                Console.WriteLine("Ritim: Seslerin veya olayların düzenli aralıklarla tekrarlanması.");
                break;
            case "risk":
                Console.WriteLine("Risk: Bir işin sonunda zarar görme veya kayba uğrama ihtimali.");
                break;
            case "robotik":
                Console.WriteLine("Robotik: Robotların tasarımı ve kontrolü ile uğraşan teknoloji dalı.");
                break;
            case "rol":
                Console.WriteLine("Rol: Bir kişinin toplumdaki veya bir oyundaki görevi.");
                break;
            case "romantik":
                Console.WriteLine("Romantik: Duyguların ön planda olduğu, hayalci.");
                break;
            case "rota":
                Console.WriteLine("Rota: Bir taşıtın izleyeceği yol; mecazen izlenen yöntem.");
                break;
            case "rutin":
                Console.WriteLine("Rutin: Alışılagelmiş, her gün aynı şekilde yapılan iş.");
                break;
            case "rütbe":
                Console.WriteLine("Rütbe: Bir hiyerarşideki mevki, derece.");
                break;
            case "rüya":
                Console.WriteLine("Rüya: Uykuda görülen hayal; mecazen çok istenen hayal.");
                break;
            case "rüşvet":
                Console.WriteLine("Rüşvet: Birine haksız çıkar sağlamak için verilen para veya mal.");
                break;
            case "runtime":
                Console.WriteLine("Runtime: Yazılımda bir programın aktif olarak çalışma süreci.");
                break;
            case "recursive":
                Console.WriteLine("Recursive: Özzyinelemeli; bir yapının kendi kendini tekrar etmesi.");
                break;
            case "refactoring":
                Console.WriteLine("Refactoring: Yazılımda kodun işlevini değiştirmeden yapısını iyileştirme.");
                break;
            case "response":
                Console.WriteLine("Response: Bir isteğe (Request) karşılık olarak gelen yanıt.");
                break;
            case "rendering":
                Console.WriteLine("Rendering: Bir modelin veya kodun görüntüye dönüştürülme işlemi.");
                break;
        }
        break;

    case 's':
    case 'S':
        Console.WriteLine("Kelime seçiniz. ( Saadet, Sade, Safha, Sağlamlık, Sahte, Sakınca, Sanal, Sanat, Saptama, Sarmal, Sav, Saye, Sebat, Sebep, Seçenek, Seçkin, Sedanter, Sektör, Sembol, Semptom, Sentez, Seri, Sermaye, Servis, Seyir, Sezgi, Sınır, Sıralama, Sicil, Simülasyon, Sinerji, Sınıf, Sistem, Site, Sorgu, Sorumluluk, Soyut, Spekülasyon, Standart, Statik, Statü, Stok, Strateji, Stres, Sunucu, Suret, Süreç, Sürüm, Sürdürülebilirlik, Sözlük ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "saadet":
                Console.WriteLine("Saadet: Mutluluk, huzur ve dirlik durumu.");
                break;
            case "sade":
                Console.WriteLine("Sade: Karmaşık olmayan, yalın ve gösterişsiz.");
                break;
            case "safha":
                Console.WriteLine("Safha: Bir sürecin bölümlerinden her biri, aşama (Phase).");
                break;
            case "sağlamlık":
                Console.WriteLine("Sağlamlık: Dayanıklı olma durumu; yazılımda hata toleransı (Robustness).");
                break;
            case "sahte":
                Console.WriteLine("Sahte: Gerçek olmayan, taklit veya uydurma.");
                break;
            case "sakınca":
                Console.WriteLine("Sakınca: Bir işin yapılmasında görülen engel veya tehlikeli durum.");
                break;
            case "sanal":
                Console.WriteLine("Sanal: Gerçekte var olmayan ancak zihinde veya bilgisayar ortamında oluşturulan (Virtual).");
                break;
            case "sanat":
                Console.WriteLine("Sanat: Bir duygunun veya güzelliğin dışavurumu olan yaratıcılık.");
                break;
            case "saptama":
                Console.WriteLine("Saptama: Bir durumu belirleme, tespit etme.");
                break;
            case "sarmal":
                Console.WriteLine("Sarmal: Helezon şeklinde olan; birbirini etkileyerek gelişen süreç.");
                break;
            case "sav":
                Console.WriteLine("Sav: İleri sürülen düşünce, iddia (Thesis).");
                break;
            case "saye":
                Console.WriteLine("Saye: Koruma, gözetme; birinin yardımıyla (Sayesinde).");
                break;
            case "sebat":
                Console.WriteLine("Sebat: Kararında direniş, bir işi sonuna kadar götürme azmi.");
                break;
            case "sebep":
                Console.WriteLine("Sebep: Bir sonucu doğuran neden, faktör.");
                break;
            case "seçenek":
                Console.WriteLine("Seçenek: Bir iş için tercih edilebilecek yollardan her biri (Option).");
                break;
            case "seçkin":
                Console.WriteLine("Seçkin: Benzerleri arasında nitelikleriyle öne çıkan (Elite).");
                break;
            case "sedanter":
                Console.WriteLine("Sedanter: Hareketsiz bir yaşam süren, sürekli oturan.");
                break;
            case "sektör":
                Console.WriteLine("Sektör: Ekonominin veya bir iş kolunun her bir bölümü.");
                break;
            case "sembol":
                Console.WriteLine("Sembol: Bir kavramı temsil eden simge.");
                break;
            case "semptom":
                Console.WriteLine("Semptom: Bir hastalığın veya durumun belirtisi.");
                break;
            case "sentez":
                Console.WriteLine("Sentez: Ayrı parçaları birleştirerek yeni bir bütün oluşturma.");
                break;
            case "seri":
                Console.WriteLine("Seri: Birbirini izleyen şeyler dizisi; hızlı.");
                break;
            case "sermaye":
                Console.WriteLine("Sermaye: Bir iş için gereken ana para ve varlıkların bütünü (Capital).");
                break;
            case "servis":
                Console.WriteLine("Servis: Hizmet; yazılımda belirli bir işlevi sunan birim (Service).");
                break;
            case "seyir":
                Console.WriteLine("Seyir: İzleme; bir sürecin gidişatı.");
                break;
            case "sezgi":
                Console.WriteLine("Sezgi: Kanıta dayanmadan bir şeyi hissetme yoluyla anlama.");
                break;
            case "sınır":
                Console.WriteLine("Sınır: Bir şeyin bittiği veya başladığı hat (Limit).");
                break;
            case "sıralama":
                Console.WriteLine("Sıralama: Nesneleri belirli bir kurala göre dizme (Sorting).");
                break;
            case "sicil":
                Console.WriteLine("Sicil: Bir kimsenin geçmişine dair tutulan resmi kayıt.");
                break;
            case "simülasyon":
                Console.WriteLine("Simülasyon: Bir sürecin taklit edilmesi, canlandırma.");
                break;
            case "sinerji":
                Console.WriteLine("Sinerji: Parçaların birleşerek kendi toplamlarından daha büyük güç oluşturması.");
                break;
            case "sınıf":
                Console.WriteLine("Sınıf: Benzer özellikli nesnelerin toplandığı kategori; yazılımda 'class'.");
                break;
            case "sistem":
                Console.WriteLine("Sistem: Bir amaca yönelik çalışan parçalar bütünü.");
                break;
            case "site":
                Console.WriteLine("Site: İnternet adresi; yerleşim birimi.");
                break;
            case "sorgu":
                Console.WriteLine("Sorgu: Veritabanından bilgi çekmek için kullanılan komut (Query).");
                break;
            case "sorumluluk":
                Console.WriteLine("Sorumluluk: Bir işin sonucunu üstlenme durumu.");
                break;
            case "soyut":
                Console.WriteLine("Soyut: Duyu organlarıyla algılanamayan, zihinsel olan (Abstract).");
                break;
            case "spekülasyon":
                Console.WriteLine("Spekülasyon: Kanıtı olmayan kurgusal tahmin; piyasa hareketi.");
                break;
            case "standart":
                Console.WriteLine("Standart: Kabul görmüş ölçü veya kural.");
                break;
            case "statik":
                Console.WriteLine("Statik: Durağan, değişmeyen.");
                break;
            case "statü":
                Console.WriteLine("Statü: Bir kişinin toplum veya kurum içindeki mevkisi.");
                break;
            case "stok":
                Console.WriteLine("Stok: Daha sonra kullanılmak üzere saklanan mal miktarı.");
                break;
            case "strateji":
                Console.WriteLine("Strateji: Uzun vadeli hedeflere ulaşmak için izlenen genel yol.");
                break;
            case "stres":
                Console.WriteLine("Stres: Zorlanma karşısında verilen fiziksel veya ruhsal tepki.");
                break;
            case "sunucu":
                Console.WriteLine("Sunucu: Veri paylaşımı yapan merkez bilgisayar (Server).");
                break;
            case "suret":
                Console.WriteLine("Suret: Görünüş, biçim; bir belgenin kopyası.");
                break;
            case "süreç":
                Console.WriteLine("Süreç: Birbirini izleyen olaylar dizisi (Process).");
                break;
            case "sürüm":
                Console.WriteLine("Sürüm: Bir yazılımın veya ürünün yayımlanan her bir hali (Version).");
                break;
            case "sürdürülebilirlik":
                Console.WriteLine("Sürdürülebilirlik: Bir durumun kalıcı ve devam edebilir olması.");
                break;
            case "sözlük":
                Console.WriteLine("Sözlük: Kelimelerin anlamlarını içeren kaynak; yazılımda anahtar-değer çifti.");
                break;
        }
        break;

    case 'ş':
    case 'Ş':
        Console.WriteLine("Kelime seçiniz. ( Şabaş, Şablon, Şafak, Şahıs, Şahit, Şahsi, Şaibe, Şaka, Şakul, Şans, Şark, Şarkı, Şart, Şasi, Şaşkınlık, Şayia, Şebeke, Şeffaflık, Şehir, Şehit, Şekil, Şema, Şematik, Şemsiye, Şeref, Şerh, Şerit, Şet, Şevk, Şey, Şiddet, Şifa, Şifre, Şifreleme, Şiir, Şikayet, Şimal, Şirket, Şirin, Şişkinlik, Şoför, Şöhret, Şube, Şura, Şuur, Şükran, Şümul, Şüphe, Şüpheli, Şükür ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "şabaş":
                Console.WriteLine("Şabaş: Alkış, beğeni; düğünlerde atılan bahşiş.");
                break;
            case "şablon":
                Console.WriteLine("Şablon: Tekrarlanan işler için kullanılan örnek kalıp (Template).");
                break;
            case "şafak":
                Console.WriteLine("Şafak: Gün doğmadan önceki aydınlık; mecazen bir sürecin başlangıcı.");
                break;
            case "şahıs":
                Console.WriteLine("Şahıs: Birey, kişi.");
                break;
            case "şahit":
                Console.WriteLine("Şahit: Bir olayı gören, tanık.");
                break;
            case "şahsi":
                Console.WriteLine("Şahsi: Kişiye özel, bireysel.");
                break;
            case "şaibe":
                Console.WriteLine("Şaibe: Bir işe karışan leke, kuşku veya hile.");
                break;
            case "şaka":
                Console.WriteLine("Şaka: Güldürmek amacıyla yapılan hareket veya söylenen söz.");
                break;
            case "şakul":
                Console.WriteLine("Şakul: Dikliği ölçmek için kullanılan ipli ağırlık, çekül.");
                break;
            case "şans":
                Console.WriteLine("Şans: Mantıkla açıklanamayan rastlantısal talih.");
                break;
            case "şark":
                Console.WriteLine("Şark: Doğu.");
                break;
            case "şarkı":
                Console.WriteLine("Şarkı: Müzik eşliğinde söylenen sözlü eser.");
                break;
            case "şart":
                Console.WriteLine("Şart: Bir şeyin gerçekleşmesi için gereken ön koşul (Condition).");
                break;
            case "şasi":
                Console.WriteLine("Şasi: Taşıtların motor ve tekerleklerini taşıyan ana iskelet.");
                break;
            case "şaşkınlık":
                Console.WriteLine("Şaşkınlık: Beklenmedik bir durum karşısında ne yapacağını bilememe hali.");
                break;
            case "şayia":
                Console.WriteLine("Şayia: Yayılmış olan söylenti, dedikodu.");
                break;
            case "şebeke":
                Console.WriteLine("Şebeke: Birbirine bağlı ağ yapısı (Network).");
                break;
            case "şeffaflık":
                Console.WriteLine("Şeffaflık: Saydamlık; yönetimde bilginin açık ve erişilebilir olması.");
                break;
            case "şehir":
                Console.WriteLine("Şehir: Büyük yerleşim birimi, kent.");
                break;
            case "şehit":
                Console.WriteLine("Şehit: Kutsal bir değer uğruna canını veren kişi.");
                break;
            case "şekil":
                Console.WriteLine("Şekil: Biçim, form; verilerin görselleştirilmiş hali.");
                break;
            case "şema":
                Console.WriteLine("Şema: Bir yapıyı veya süreci özetleyen çizim (Diagram).");
                break;
            case "şematik":
                Console.WriteLine("Şematik: Bir çizelgeye veya plana dayalı olan.");
                break;
            case "şemsiye":
                Console.WriteLine("Şemsiye: Yağmurdan koruyan araç; mecazen kapsayıcı yapı.");
                break;
            case "şeref":
                Console.WriteLine("Şeref: Onur, saygınlık.");
                break;
            case "şerh":
                Console.WriteLine("Şerh: Bir metni açıklama; bir karara eklenen kısıtlayıcı not.");
                break;
            case "şerit":
                Console.WriteLine("Şerit: Dar ve uzun parça; yolun her bir bölümü.");
                break;
            case "şet":
                Console.WriteLine("Şet: Baraj, bent.");
                break;
            case "şevk":
                Console.WriteLine("Şevk: İstek, neşe ve çalışma arzusu.");
                break;
            case "şey":
                Console.WriteLine("Şey: İsmi belirtilmeyen herhangi bir nesne veya durum.");
                break;
            case "şiddet":
                Console.WriteLine("Şiddet: Bir gücün derecesi; kaba kuvvet.");
                break;
            case "şifa":
                Console.WriteLine("Şifa: Hastalıktan kurtulma, sağlığa kavuşma.");
                break;
            case "şifre":
                Console.WriteLine("Şifre: Gizli tutulan parola veya kodlama yöntemi (Password/Cipher).");
                break;
            case "şifreleme":
                Console.WriteLine("Şifreleme: Verinin güvenli hale getirilmesi işlemi (Encryption).");
                break;
            case "şiir":
                Console.WriteLine("Şiir: Duyguların ölçülü ve etkileyici bir dille anlatımı.");
                break;
            case "şikayet":
                Console.WriteLine("Şikayet: Memnuniyetsizliği dile getirme.");
                break;
            case "şimal":
                Console.WriteLine("Şimal: Kuzey.");
                break;
            case "şirket":
                Console.WriteLine("Şirket: Ticari bir amaçla kurulan ortaklık, kurum.");
                break;
            case "şirin":
                Console.WriteLine("Şirin: Tatlı, sempatik, cana yakın.");
                break;
            case "şişkinlik":
                Console.WriteLine("Şişkinlik: Hacimsel artış; verilerde yapay büyüme.");
                break;
            case "şoför":
                Console.WriteLine("Şoför: Sürücü, araç kullanan kişi.");
                break;
            case "şöhret":
                Console.WriteLine("Şöhret: Ün, tanınmış olma durumu.");
                break;
            case "şube":
                Console.WriteLine("Şube: Bir kurumun alt birimi, dal.");
                break;
            case "şura":
                Console.WriteLine("Şura: Karar almak için toplanan kurul, meclis.");
                break;
            case "şuur":
                Console.WriteLine("Şuur: Bilinç, farkındalık.");
                break;
            case "şükran":
                Console.WriteLine("Şükran: Minnettar olma, teşekkür etme.");
                break;
            case "şümul":
                Console.WriteLine("Şümul: Kapsama, içine alma.");
                break;
            case "şüphe":
                Console.WriteLine("Şüphe: Bir durumdan kuşku duyma, belirsizlik.");
                break;
            case "şüpheli":
                Console.WriteLine("Şüpheli: Net olmayan, zanlı.");
                break;
            case "şükür":
                Console.WriteLine("Şükür: Sahip olunan bir şey için duyulan memnuniyet.");
                break;
        }
        break;

    case 't':
    case 'T':
        Console.WriteLine("Kelime seçiniz. ( Tabaka, Taban, Tabiat, Tahakkuk, Tahmin, Tahsis, Tahribat, Takas, Takvim, Talep, Tampon, Tanım, Tanı, Tarafsızlık, Tasarım, Taslak, Tasnif, Tasdik, Taviz, Tavsiye, Tazminat, Tebliğ, Tedarik, Tedbir, Tehdit, Tekil, Teknik, Teknoloji, Tekrar, Telafi, Temas, Temel, Teminat, Temsil, Teori, Tercih, Terfi, Terim, Tesis, Teslimat, Tespit, Test, Teşvik, Titizlik, Tolerans, Toplam, Toplum, Trafik, Trafo, Tutar ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "tabaka":
                Console.WriteLine("Tabaka: Katman; yazılım mimarisinde farklı sorumlulukları olan seviye (Layer).");
                break;
            case "taban":
                Console.WriteLine("Taban: Bir şeyin en alt kısmı, dayanak; veritabanı (Database).");
                break;
            case "tabiat":
                Console.WriteLine("Tabiat: Doğa; bir kişinin veya nesnenin karakteristik özelliği.");
                break;
            case "tahakkuk":
                Console.WriteLine("Tahakkuk: Gerçekleşme; bir verginin veya ödemenin ödenecek aşamaya gelmesi.");
                break;
            case "tahmin":
                Console.WriteLine("Tahmin: Yaklaşık olarak belirleme, kestirim (Prediction/Estimation).");
                break;
            case "tahsis":
                Console.WriteLine("Tahsis: Bir şeyi birine veya bir amaca ayırma (Allocation).");
                break;
            case "tahribat":
                Console.WriteLine("Tahribat: Yıkım, büyük ölçüde zarar verme.");
                break;
            case "takas":
                Console.WriteLine("Takas: Malın mal ile değiştirilmesi; veri değişimi.");
                break;
            case "takvim":
                Console.WriteLine("Takvim: Zamanın gün, ay, yıl olarak bölümlenmesi; iş planı.");
                break;
            case "talep":
                Console.WriteLine("Talep: İstek; piyasada bir mala karşı duyulan ihtiyaç (Demand).");
                break;
            case "tampon":
                Console.WriteLine("Tampon: Darbeyi azaltan engel; yazılımda geçici veri saklama alanı (Buffer).");
                break;
            case "tanım":
                Console.WriteLine("Tanım: Bir kavramın özelliklerini eksiksiz açıklama (Definition).");
                break;
            case "tanı":
                Console.WriteLine("Tanı: Teşhis; bir durumun ne olduğunu belirleme.");
                break;
            case "tarafsızlık":
                Console.WriteLine("Tarafsızlık: Bir yanı tutmama, nesnellik (Impartiality).");
                break;
            case "tasarım":
                Console.WriteLine("Tasarım: Bir ürünün veya sistemin planlanmış biçimi (Design).");
                break;
            case "taslak":
                Console.WriteLine("Taslak: Bir işin bitmemiş ilk hali, şablon (Draft).");
                break;
            case "tasnif":
                Console.WriteLine("Tasnif: Sınıflandırma, türlerine göre ayırma.");
                break;
            case "tasdik":
                Console.WriteLine("Tasdik: Onaylama, doğrulama.");
                break;
            case "taviz":
                Console.WriteLine("Taviz: Ödün; bir anlaşma için kendi isteğinden vazgeçme.");
                break;
            case "tavsiye":
                Console.WriteLine("Tavsiye: Birine yol göstermek amacıyla söylenen söz, öneri.");
                break;
            case "tazminat":
                Console.WriteLine("Tazminat: Verilen bir zararın karşılığı olarak ödenen bedel.");
                break;
            case "tebliğ":
                Console.WriteLine("Tebliğ: Resmi olarak bildirme, duyurma.");
                break;
            case "tedarik":
                Console.WriteLine("Tedarik: Gerekli olan şeyi bulup sağlama (Procurement).");
                break;
            case "tedbir":
                Console.WriteLine("Tedbir: Önlem; kötü bir sonucu önlemek için hazırlık.");
                break;
            case "tehdit":
                Console.WriteLine("Tehdit: Korkutma; bir sistemin güvenliğini riske atan unsur (Threat).");
                break;
            case "tekil":
                Console.WriteLine("Tekil: Sadece bir tane olan; yazılımda benzersiz olan (Unique/Singular).");
                break;
            case "teknik":
                Console.WriteLine("Teknik: Bir işin uygulama yolu, beceri ve yöntem bütünü.");
                break;
            case "teknoloji":
                Console.WriteLine("Teknoloji: Bilimin pratik yaşamda uygulanması.");
                break;
            case "tekrar":
                Console.WriteLine("Tekrar: Bir işin yeniden yapılması; döngü.");
                break;
            case "telafi":
                Console.WriteLine("Telafi: Eksikliği veya zararı giderme.");
                break;
            case "temas":
                Console.WriteLine("Temas: Dokunma, iletişim kurma.");
                break;
            case "temel":
                Console.WriteLine("Temel: Bir şeyin en alt kısmı, esası (Base/Foundation).");
                break;
            case "teminat":
                Console.WriteLine("Teminat: Güvence; bir sözün tutulacağına dair verilen değer.");
                break;
            case "temsil":
                Console.WriteLine("Temsil: Birinin veya bir grubun adına hareket etme.");
                break;
            case "teori":
                Console.WriteLine("Teori: Kuram; bir olayı açıklayan sistemli düşünce yapısı.");
                break;
            case "tercih":
                Console.WriteLine("Tercih: Seçenekler arasında birini öne alma.");
                break;
            case "terfi":
                Console.WriteLine("Terfi: Bir işte daha üst bir makama yükselme.");
                break;
            case "terim":
                Console.WriteLine("Terim: Bir bilim veya sanat dalına özgü özel kelime.");
                break;
            case "tesis":
                Console.WriteLine("Tesis: Kurma, oluşturma; üretim yapılan yer.");
                break;
            case "teslimat":
                Console.WriteLine("Teslimat: Bir malın alıcıya ulaştırılması (Delivery).");
                break;
            case "tespit":
                Console.WriteLine("Tespit: Bir durumu net olarak belirleme.");
                break;
            case "test":
                Console.WriteLine("Test: Bir sistemin doğruluğunu denetleme işlemi.");
                break;
            case "teşvik":
                Console.WriteLine("Teşvik: Birini bir işi yapmaya isteklendirme.");
                break;
            case "titizlik":
                Console.WriteLine("Titizlik: Bir işi yaparken gösterilen aşırı dikkat.");
                break;
            case "tolerans":
                Console.WriteLine("Tolerans: Hoşgörü; bir sistemin hata payı.");
                break;
            case "toplam":
                Console.WriteLine("Toplam: Sayıların veya değerlerin bütünü (Total).");
                break;
            case "toplum":
                Console.WriteLine("Toplum: Aynı coğrafyada ve kurallarla yaşayan insanlar bütünü.");
                break;
            case "trafik":
                Console.WriteLine("Trafik: Ulaşım yoğunluğu; ağ üzerindeki veri akışı.");
                break;
            case "trafo":
                Console.WriteLine("Trafo: Elektrik gerilimini değiştiren cihaz.");
                break;
            case "tutar":
                Console.WriteLine("Tutar: Para miktarı, meblağ.");
                break;
        }
        break;

    case 'u':
    case 'U':
        Console.WriteLine("Kelime seçiniz. ( Uç, Uhde, Ulaşım, Ulaştırma, Ulusal, Uluslararası, Umumi, Unsur, Unvan, Usul, Uyarı, Uygulama, Uygunluk, Uyruk, Uydurma, Uyum, Uyumluluk, Uyumlanma, Uzantı, Uzlaşma, Uzman, Uzmanlık, Uzunluk, Uzuv, Ücret, Ucuzluk, Ufuk, Ulaşılabilirlik, Ünite, Ünlem, Üretim, Üreteç, Us, Ustalık, Üstünlük, Üye, Üyelik, Üyer, Ücretlendirme, Ülke, Ultimatom, Uyduruk, Uyarıcı, Ülkesel, Üst, Üzeri, Ücretli, Üzerinde, Uydurmacılık, Update ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "uç":
                Console.WriteLine("Uç: Bir nesnenin en kenar noktası; yazılımda bir sistemin dış dünyaya açılan kapısı (Endpoint).");
                break;
            case "uhde":
                Console.WriteLine("Uhde: Birinin üzerine aldığı görev, sorumluluk.");
                break;
            case "ulaşım":
                Console.WriteLine("Ulaşım: Bir yerden bir yere gitme; verinin iletilmesi.");
                break;
            case "ulaştırma":
                Console.WriteLine("Ulaştırma: Nesnelerin veya bilgilerin hedefe iletilmesi süreci.");
                break;
            case "ulusal":
                Console.WriteLine("Ulusal: Bir millete özgü olan, milli.");
                break;
            case "uluslararası":
                Console.WriteLine("Uluslararası: Birden fazla milleti kapsayan, global.");
                break;
            case "umumi":
                Console.WriteLine("Umumi: Herkese açık olan, genel.");
                break;
            case "unsur":
                Console.WriteLine("Unsur: Bir bütünü oluşturan temel parçalardan her biri, öge.");
                break;
            case "unvan":
                Console.WriteLine("Unvan: Bir kimsenin rütbesini veya mesleki konumunu belirten isim.");
                break;
            case "usul":
                Console.WriteLine("Usul: Bir işin yapılış yöntemi, yol yordam.");
                break;
            case "uyarı":
                Console.WriteLine("Uyarı: Bir hatayı veya tehlikeyi önlemek için yapılan bildirim.");
                break;
            case "uygulama":
                Console.WriteLine("Uygulama: Teorik bir bilgiyi hayata geçirme; yazılım (Application).");
                break;
            case "uygunluk":
                Console.WriteLine("Uygunluk: Bir kurala veya standarta göre olma durumu.");
                break;
            case "uyruk":
                Console.WriteLine("Uyruk: Bir devlete bağlı olma durumu, tabiiyet.");
                break;
            case "uydurma":
                Console.WriteLine("Uydurma: Gerçek olmayan, sonradan türetilen veya yalan olan.");
                break;
            case "uyum":
                Console.WriteLine("Uyum: Parçaların birbirine dengeli şekilde oturması (Harmony/Compatibility).");
                break;
            case "uyumluluk":
                Console.WriteLine("Uyumluluk: Farklı sistemlerin bir arada sorunsuz çalışabilmesi.");
                break;
            case "uyumlanma":
                Console.WriteLine("Uyumlanma: Yeni bir duruma veya çevreye alışma süreci.");
                break;
            case "uzantı":
                Console.WriteLine("Uzantı: Bir şeyin eklenen parçası; dosya türünü belirten ek (Extension).");
                break;
            case "uzlaşma":
                Console.WriteLine("Uzlaşma: Tarafların ortak bir noktada buluşup anlaşması.");
                break;
            case "uzman":
                Console.WriteLine("Uzman: Bir konuda derinlemesine bilgi ve becerisi olan kişi.");
                break;
            case "uzmanlık":
                Console.WriteLine("Uzmanlık: Bir alanda ustalaşmış olma durumu.");
                break;
            case "uzunluk":
                Console.WriteLine("Uzunluk: Bir nesnenin boyu; veri dizisindeki eleman sayısı.");
                break;
            case "uzuv":
                Console.WriteLine("Uzuv: Vücut parçası; bir mekanizmanın işlevsel bölümü.");
                break;
            case "ucret":
                Console.WriteLine("Ücret: Bir emek veya hizmet karşılığında ödenen para.");
                break;
            case "ucuzluk":
                Console.WriteLine("Ucuzluk: Fiyatın değerinden veya alışılmıştan düşük olması.");
                break;
            case "ufuk":
                Console.WriteLine("Ufuk: Yerle göğün birleştiği hat; mecazen görüş açısı.");
                break;
            case "ulaşılabilirlik":
                Console.WriteLine("Ulaşılabilirlik: Bir hizmetin veya verinin erişilebilir olma durumu.");
                break;
            case "unite":
                Console.WriteLine("Ünite: Bir bütünü oluşturan bağımsız birimlerden her biri (Unit).");
                break;
            case "unlem":
                Console.WriteLine("Ünlem: Duygu veya sesleniş bildiren kelime/işaret.");
                break;
            case "uretim":
                Console.WriteLine("Üretim: Hammaddeyi işleyerek yeni bir mal elde etme.");
                break;
            case "ureteç":
                Console.WriteLine("Üreteç: Bir şeyi üreten sistem veya cihaz (Generator).");
                break;
            case "us":
                Console.WriteLine("Us: Akıl.");
                break;
            case "ustalik":
                Console.WriteLine("Ustalık: Bir zanaatı veya işi en iyi şekilde yapma becerisi.");
                break;
            case "ustunluk":
                Console.WriteLine("Üstünlük: Nitelik bakımından diğerlerinden önde olma.");
                break;
            case "uye":
                Console.WriteLine("Üye: Bir topluluğa veya sisteme kayıtlı olan kişi.");
                break;
            case "uyelik":
                Console.WriteLine("Üyelik: Bir gruba veya sisteme dahil olma statüsü.");
                break;
            case "uyer":
                Console.WriteLine("Üyer: Bir yerin üst kısmı.");
                break;
            case "ucretlendirme":
                Console.WriteLine("Ücretlendirme: Bir hizmetin bedelini belirleme işlemi.");
                break;
            case "ulke":
                Console.WriteLine("Ülke: Bir devletin egemenliği altındaki toprakların bütünü.");
                break;
            case "ultimatom":
                Console.WriteLine("Ultimatom: Bir devletin diğerine verdiği son ve kesin şartlı nota.");
                break;
            case "uyduruk":
                Console.WriteLine("Uyduruk: Kalitesiz veya asılsız.");
                break;
            case "uyarıcı":
                Console.WriteLine("Uyarıcı: Harekete geçiren, dikkat çeken unsur.");
                break;
            case "ulkesel":
                Console.WriteLine("Ülkesel: Bir ülkenin tamamını ilgilendiren.");
                break;
            case "ust":
                Console.WriteLine("Üst: Bir şeyin yukarı kısmı; rütbece daha yukarıda olan.");
                break;
            case "uzeri":
                Console.WriteLine("Üzeri: Bir şeyin dış yüzeyi veya üstü.");
                break;
            case "ucretli":
                Console.WriteLine("Ücretli: Karşılığında ödeme yapılan veya maaşlı çalışan.");
                break;
            case "uzerinde":
                Console.WriteLine("Üzerinde: Bir nesnenin veya konunun üstünde olma hali.");
                break;
            case "uydurmacılık":
                Console.WriteLine("Uydurmacılık: Sürekli yalan veya asılsız şeyler üretme eğilimi.");
                break;
            case "update":
                Console.WriteLine("Update: Güncelleme; sistemin yeni versiyona yükseltilmesi.");
                break;
        }
        break;

    case 'ü':
    case 'Ü':
        Console.WriteLine("Kelime seçiniz. ( Ücret, Üretim, Üretkenlik, Üreteç, Ünite, Üniversite, Ünvan, Üye, Üyelik, Ürün, Ütopya, Üst, Üstünlük, Üstbilgi, Üçgen, Üslup, Üstat, Ürem, Ürperti, Üretici, Ünlem, Ün, Ürküntü, Üssü, Üstel, Üs, Üvey, Üzüntü, Üretimsel, Üçüncü, Üçleme, Ücretsiz, Ücretlendirme, Ümit, Üniteleşme, Üyeleşme, Ürün gamı, Üstlimit, Üzeri, Üzerinde, Üleşme, Üretilmiş, Ünlü, Ünsüz, Üstün, Üzere, Üretimhane, Üstenme, Üç boyutlu, Üzgün ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "ücret":
                Console.WriteLine("Ücret: Bir emek veya hizmet karşılığında ödenen para bedeli.");
                break;
            case "üretim":
                Console.WriteLine("Üretim: Hammaddelerin işlenerek yeni bir mal veya hizmete dönüştürülmesi.");
                break;
            case "üretkenlik":
                Console.WriteLine("Üretkenlik: Belirli bir sürede elde edilen verim düzeyi (Productivity).");
                break;
            case "üreteç":
                Console.WriteLine("Üreteç: Bir şeyi oluşturan veya enerji üreten sistem (Generator).");
                break;
            case "ünite":
                Console.WriteLine("Ünite: Bir bütünü oluşturan bağımsız birimlerden her biri (Unit).");
                break;
            case "üniversite":
                Console.WriteLine("Üniversite: En üst düzeyde eğitim ve bilimsel araştırma yapılan kurum.");
                break;
            case "ünvan":
                Console.WriteLine("Ünvan: Bir kimsenin mesleki veya sosyal konumunu belirten ad.");
                break;
            case "üye":
                Console.WriteLine("Üye: Bir topluluğa veya sisteme kayıtlı olan her bir kişi (Member).");
                break;
            case "üyelik":
                Console.WriteLine("Üyelik: Bir sisteme dahil olma ve haklardan yararlanma statüsü.");
                break;
            case "ürün":
                Console.WriteLine("Ürün: Bir çalışma veya doğa sonucu elde edilen nesne (Product).");
                break;
            case "ütopya":
                Console.WriteLine("Ütopya: Gerçekleşmesi imkansız görülen, hayali ve mükemmel toplum tasarımı.");
                break;
            case "üst":
                Console.WriteLine("Üst: Bir şeyin yukarı kısmı; makamca daha yetkili olan (Senior/Upper).");
                break;
            case "üstünlük":
                Console.WriteLine("Üstünlük: Nitelik veya nicelik bakımından diğerlerinden önde olma durumu.");
                break;
            case "üstbilgi":
                Console.WriteLine("Üstbilgi: Bir belgenin veya veri paketinin başındaki tanıtıcı kısım (Header).");
                break;
            case "üçgen":
                Console.WriteLine("Üçgen: Üç kenarı ve üç açısı olan geometrik şekil.");
                break;
            case "üslup":
                Console.WriteLine("Üslup: Bir kişinin kendine has anlatım veya iş yapış tarzı.");
                break;
            case "üstat":
                Console.WriteLine("Üstat: Bir bilim veya sanat dalında en yüksek dereceye ulaşmış kişi.");
                break;
            case "ürem":
                Console.WriteLine("Ürem: Faiz, getiri.");
                break;
            case "ürperti":
                Console.WriteLine("Ürperti: Korku veya heyecanla gelen titreme hissi.");
                break;
            case "üretici":
                Console.WriteLine("Üretici: Mal veya hizmeti meydana getiren kişi veya kuruluş.");
                break;
            case "ünlem":
                Console.WriteLine("Ünlem: Ani duyguları veya çağrıları ifade eden kelime.");
                break;
            case "ün":
                Console.WriteLine("Ün: Herkesçe tanınma durumu, şöhret.");
                break;
            case "ürküntü":
                Console.WriteLine("Ürküntü: Hafif korku duyma hali.");
                break;
            case "üssü":
                Console.WriteLine("Üssü: Bir sayının kendisiyle kaç kez çarpılacağını gösteren değer.");
                break;
            case "üstel":
                Console.WriteLine("Üstel: Artışın katlanarak devam ettiği durum (Exponential).");
                break;
            case "üs":
                Console.WriteLine("Üs: Harekat merkezi; matematikte kuvvet.");
                break;
            case "üvey":
                Console.WriteLine("Üvey: Kan bağı olmayan ancak aile bağına dahil olan.");
                break;
            case "üzüntü":
                Console.WriteLine("Üzüntü: Bir kayıp veya olumsuzluk karşısında duyulan keder.");
                break;
            case "üretimsel":
                Console.WriteLine("Üretimsel: Üretim süreciyle ilgili olan.");
                break;
            case "üçüncü":
                Console.WriteLine("Üçüncü: Sıralamada ikiden sonra gelen.");
                break;
            case "üçleme":
                Console.WriteLine("Üçleme: Birbirini tamamlayan üç eserden oluşan bütün.");
                break;
            case "ücretsiz":
                Console.WriteLine("Ücretsiz: Karşılığında para ödenmeyen, bedava.");
                break;
            case "ücretlendirme":
                Console.WriteLine("Ücretlendirme: Bir hizmetin bedelini belirleme politikası.");
                break;
            case "ümit":
                Console.WriteLine("Ümit: Gerçekleşmesi beklenen güzel şeylere duyulan güven, umut.");
                break;
            case "üniteleşme":
                Console.WriteLine("Üniteleşme: Birimler haline getirilme süreci.");
                break;
            case "üyeleşme":
                Console.WriteLine("Üyeleşme: Bir topluluğa katılma eylemi.");
                break;
            case "ürün gamı":
                Console.WriteLine("Ürün Gamı: Bir işletmenin sunduğu tüm ürünlerin çeşitliliği.");
                break;
            case "üstlimit":
                Console.WriteLine("Üstlimit: Çıkılabilecek en yüksek nokta, tavan değer.");
                break;
            case "üzeri":
                Console.WriteLine("Üzeri: Bir nesnenin üst yüzeyi.");
                break;
            case "üzerinde":
                Console.WriteLine("Üzerinde: Bir konu veya nesne hakkındaki çalışma durumu.");
                break;
            case "üleşme":
                Console.WriteLine("Üleşme: Paylaşma, bölüşme.");
                break;
            case "üretilmiş":
                Console.WriteLine("Üretilmiş: Hammaddeden mamul hale getirilmiş.");
                break;
            case "ünlü":
                Console.WriteLine("Ünlü: Tanınmış kişi; Türkçedeki sesli harfler.");
                break;
            case "ünsüz":
                Console.WriteLine("Ünsüz: Tanınmamış; Türkçedeki sessiz harfler.");
                break;
            case "üstün":
                Console.WriteLine("Üstün: Benzerlerinden daha nitelikli olan.");
                break;
            case "üzere":
                Console.WriteLine("Üzere: Amacıyla, şartıyla anlamlarına gelen edat.");
                break;
            case "üretimhane":
                Console.WriteLine("Üretimhane: İmalatın yapıldığı yer.");
                break;
            case "üstenme":
                Console.WriteLine("Üstenme: Bir sorumluluğu kabul etme.");
                break;
            case "üç boyutlu":
                Console.WriteLine("Üç Boyutlu: Eni, boyu ve derinliği olan (3D).");
                break;
            case "üzgün":
                Console.WriteLine("Üzgün: Moral bozukluğu yaşayan, kederli.");
                break;
        }
        break;

    case 'v':
    case 'V':
        Console.WriteLine("Kelime seçiniz. ( Vade, Vaha, Vahim, Vakar, Vakıf, Vakit, Vakum, Valide, Valör, Vandalizm, Varyans, Varyasyon, Vasat, Vasıf, Vasiyet, Vatan, Vaziyet, Vebal, Veca, Vecize, Vefa, Vekalet, Vektör, Verem, Vergi, Veri, Verimlilik, Veritabanı, Vesayet, Vesile, Vibrasyon, Vicdan, Vida, Vilayet, Viraj, Virtual, Virüs, Vizite, Vizyon, Vokal, Volan, Volkan, Voltaj, Volume, Vukuat, Vurgu, Vurgun, Vuslat, Vuzuh, vücut ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "vade":
                Console.WriteLine("Vade: Bir işin yapılması veya bir borcun ödenmesi için tanınan süre.");
                break;
            case "vaha":
                Console.WriteLine("Vaha: Çöllerde suyun bulunduğu, bitkilerin yetiştiği verimli alan.");
                break;
            case "vahim":
                Console.WriteLine("Vahim: Çok tehlikeli, korkutucu ve ağır sonuçlar doğurabilecek durum.");
                break;
            case "vakar":
                Console.WriteLine("Vakar: Ağırbaşlılık, haysiyetli ve ciddi duruş.");
                break;
            case "vakıf":
                Console.WriteLine("Vakıf: Bir hizmetin gelecekte de sürmesi için bağışlanan varlık; bir konuyu iyi bilen.");
                break;
            case "vakit":
                Console.WriteLine("Vakit: Zaman, bir iş için ayrılan süre.");
                break;
            case "vakum":
                Console.WriteLine("Vakum: Hava veya gazın tamamen boşaltıldığı basınçsız ortam.");
                break;
            case "valide":
                Console.WriteLine("Valide: Anne.");
                break;
            case "valör":
                Console.WriteLine("Valör: Bankacılıkta işlemin faiz başlangıç tarihi.");
                break;
            case "vandalizm":
                Console.WriteLine("Vandalizm: Bilerek ve isteyerek kamu mallarına veya sanat eserlerine zarar verme.");
                break;
            case "varyans":
                Console.WriteLine("Varyans: İstatistiksel verilerin ortalamadan ne kadar saptığını gösteren ölçü.");
                break;
            case "varyasyon":
                Console.WriteLine("Varyasyon: Bir şeyin farklı biçimi, değişik türü (Variation).");
                break;
            case "vasat":
                Console.WriteLine("Vasat: Ortalama, orta seviye; ne iyi ne kötü.");
                break;
            case "vasıf":
                Console.WriteLine("Vasıf: Nitelik, özellik, birini diğerlerinden ayıran yetenek.");
                break;
            case "vasiyet":
                Console.WriteLine("Vasiyet: Bir kimsenin ölümünden sonra yapılmasını istediği şey.");
                break;
            case "vatan":
                Console.WriteLine("Vatan: Bir halkın üzerinde yaşadığı, kültürünü oluşturduğu toprak parçası.");
                break;
            case "vaziyet":
                Console.WriteLine("Vaziyet: Durum, konum; bir olayın o anki görünüşü.");
                break;
            case "vebal":
                Console.WriteLine("Vebal: Manevi sorumluluk, günah.");
                break;
            case "veca":
                Console.WriteLine("Veca: Ağrı, sızı.");
                break;
            case "vecize":
                Console.WriteLine("Vecize: Özlü söz; kısa ama derin anlamlı ifade.");
                break;
            case "vefa":
                Console.WriteLine("Vefa: Sevgide ve bağlılıkta süreklilik, yapılan iyiliği unutmama.");
                break;
            case "vekalet":
                Console.WriteLine("Vekalet: Birinin adına iş yapma yetkisi.");
                break;
            case "vektör":
                Console.WriteLine("Vektör: Fizikte yönü ve şiddeti olan büyüklük; yazılımda dinamik dizi.");
                break;
            case "verem":
                Console.WriteLine("Verem: Akciğerleri etkileyen bulaşıcı bir hastalık (Tüberküloz).");
                break;
            case "vergi":
                Console.WriteLine("Vergi: Kamu hizmetleri için devletin kişilerden topladığı pay.");
                break;
            case "veri":
                Console.WriteLine("Veri: İşlenmemiş bilgi parçası, analiz için kullanılan girdi (Data).");
                break;
            case "verimlilik":
                Console.WriteLine("Verimlilik: Girdilerle en yüksek çıktıyı elde etme derecesi (Productivity).");
                break;
            case "veritabanı":
                Console.WriteLine("Veritabanı: Verilerin düzenli ve yapılandırılmış şekilde saklandığı sistem.");
                break;
            case "vesayet":
                Console.WriteLine("Vesayet: Birinin haklarını korumak amacıyla atanan yasal denetim.");
                break;
            case "vesile":
                Console.WriteLine("Vesile: Sebep, bahane, bir işin gerçekleşmesine yol açan durum.");
                break;
            case "vibrasyon":
                Console.WriteLine("Vibrasyon: Titreşim.");
                break;
            case "vicdan":
                Console.WriteLine("Vicdan: Kişinin kendi davranışlarını ahlaki yönden yargılama gücü.");
                break;
            case "vida":
                Console.WriteLine("Vida: Parçaları birbirine tutturmaya yarayan dişli metal çubuk.");
                break;
            case "vilayet":
                Console.WriteLine("Vilayet: İl, şehir yönetimi.");
                break;
            case "viraj":
                Console.WriteLine("Viraj: Yolun büküldüğü yer, dönemeç.");
                break;
            case "virtual":
                Console.WriteLine("Virtual: Sanal; yazılımda fiziksel olmayan ama işlevsel olan yapı.");
                break;
            case "virüs":
                Console.WriteLine("Virüs: Bulaşıcı hastalık yapıcı mikrop; bilgisayara zarar veren yazılım.");
                break;
            case "vizite":
                Console.WriteLine("Vizite: Doktorun hastayı muayene etmesi.");
                break;
            case "vizyon":
                Console.WriteLine("Vizyon: Geleceğe dair tasarım, uzun vadeli hedef ve bakış açısı.");
                break;
            case "vokal":
                Console.WriteLine("Vokal: Sesle ilgili; şarkı söyleyen ses.");
                break;
            case "volan":
                Console.WriteLine("Volan: Makinelerde hızı dengeleyen ağır tekerlek.");
                break;
            case "volkan":
                Console.WriteLine("Volkan: Yanardağ.");
                break;
            case "voltaj":
                Console.WriteLine("Voltaj: Elektrik potansiyel farkı, gerilim.");
                break;
            case "volume":
                Console.WriteLine("Volume: Hacim; ses şiddeti seviyesi.");
                break;
            case "vukuat":
                Console.WriteLine("Vukuat: Meydana gelen olaylar, genellikle asayiş olayları.");
                break;
            case "vurgu":
                Console.WriteLine("Vurgu: Konuşurken bir heceyi veya kelimeyi daha baskılı söyleme.");
                break;
            case "vurgun":
                Console.WriteLine("Vurgun: Denizde basınç farkından kaynaklanan rahatsızlık; haksız kazanç.");
                break;
            case "vuslat":
                Console.WriteLine("Vuslat: Sevilen kişiye veya amaca ulaşma, kavuşma.");
                break;
            case "vuzuh":
                Console.WriteLine("Vuzuh: Açıklık, belirginlik, anlaşılır olma durumu.");
                break;
            case "vücut":
                Console.WriteLine("Vücut: Canlı varlığın fiziksel yapısı, gövde.");
                break;
        }
        break;


    case 'y':
    case 'Y':
        Console.WriteLine("Kelime seçiniz. ( Yadsıma, Yağı, Yakınsama, Yaklaşım, Yalan, Yalınlık, Yalıtım, Yanılsama, Yankı, Yapay, Yapı, Yaptırım, Yaratıcılık, Yargı, Yarışma, Yasa, Yasak, Yaşam, Yatırım, Yavan, Yavuz, Yayın, Yazılım, Yedekleme, Yegâne, Yeis, Yektâ, Yelken, Yenileme, Yenilik, Yerel, Yerelleştirme, Yetenek, Yeterlilik, Yetki, Yığın, Yıkım, Yıllık, Yıldız, Yoğunluk, Yol, Yolsuzluk, Yorum, Yöndem, Yönerge, Yönetim, Yönetişim, Yöntem, Yönlendirme, Yükümlülük ): ");
        kelimeler = Console.ReadLine().ToLower();

        switch (kelimeler)
        {
            case "yadsıma":
                Console.WriteLine("Yadsıma: İnkar etme, kabul etmeme.");
                break;
            case "yağı":
                Console.WriteLine("Yağı: Düşman.");
                break;
            case "yakınsama":
                Console.WriteLine("Yakınsama: Farklı noktaların birbirine yaklaşması (Convergence).");
                break;
            case "yaklaşım":
                Console.WriteLine("Yaklaşım: Bir sorunu ele alma biçimi, yöntem (Approach).");
                break;
            case "yalan":
                Console.WriteLine("Yalan: Gerçeğe aykırı olan söz.");
                break;
            case "yalınlık":
                Console.WriteLine("Yalınlık: Sadelik, karmaşıklıktan uzak olma (Simplicity).");
                break;
            case "yalıtım":
                Console.WriteLine("Yalıtım: İzolasyon; dış etkilerden koruma.");
                break;
            case "yanılsama":
                Console.WriteLine("Yanılsama: İllüzyon; gerçeği yanlış algılama.");
                break;
            case "yankı":
                Console.WriteLine("Yankı: Sesin yansıması; eko.");
                break;
            case "yapay":
                Console.WriteLine("Yapay: Doğal olmayan, insan eliyle yapılmış.");
                break;
            case "yapı":
                Console.WriteLine("Yapı: Bir bütünü oluşturan parçaların düzeni (Structure).");
                break;
            case "yaptırım":
                Console.WriteLine("Yaptırım: Bir kurala uymamanın yasal veya sosyal sonucu.");
                break;
            case "yaratıcılık":
                Console.WriteLine("Yaratıcılık: Yeni ve özgün fikirler üretme yetisi.");
                break;
            case "yargı":
                Console.WriteLine("Yargı: Bir hükme varma süreci; hukuk sistemi.");
                break;
            case "yarışma":
                Console.WriteLine("Yarışma: Üstünlük sağlamak için yapılan mücadele.");
                break;
            case "yasa":
                Console.WriteLine("Yasa: Devletin koyduğu uyulması zorunlu kurallar (Law).");
                break;
            case "yasak":
                Console.WriteLine("Yasak: Yapılmasına izin verilmeyen eylem.");
                break;
            case "yaşam":
                Console.WriteLine("Yaşam: Doğumdan ölüme kadar geçen süreç.");
                break;
            case "yatırım":
                Console.WriteLine("Yatırım: Gelecekte kazanç sağlamak için yapılan harcama (Investment).");
                break;
            case "yavan":
                Console.WriteLine("Yavan: Tadı tuzu olmayan; mecazen sıkıcı.");
                break;
            case "yavuz":
                Console.WriteLine("Yavuz: Güçlü, sert ve yiğit.");
                break;
            case "yayın":
                Console.WriteLine("Yayın: Bilginin veya medyanın halka ulaştırılması.");
                break;
            case "yazılım":
                Console.WriteLine("Yazılım: Bilgisayarı çalıştıran kod ve program bütünü (Software).");
                break;
            case "yedekleme":
                Console.WriteLine("Yedekleme: Verilerin kaybını önlemek için kopyalanması (Backup).");
                break;
            case "yegâne":
                Console.WriteLine("Yegâne: Tek, eşi benzeri olmayan.");
                break;
            case "yeis":
                Console.WriteLine("Yeis: Umutsuzluk, keder.");
                break;
            case "yektâ":
                Console.WriteLine("Yektâ: Tek, benzersiz.");
                break;
            case "yelken":
                Console.WriteLine("Yelken: Rüzgar gücüyle gemiyi yürüten bez; mecazen girişim.");
                break;
            case "yenileme":
                Console.WriteLine("Yenileme: Eskimiş olanı düzeltme (Renewal/Refresh).");
                break;
            case "yenilik":
                Console.WriteLine("Yenilik: İnovasyon; yeni bir yöntem veya araç.");
                break;
            case "yerele":
                Console.WriteLine("Yerel: Sadece belli bir bölgeyi ilgilendiren (Local).");
                break;
            case "yerelleştirme":
                Console.WriteLine("Yerelleştirme: Yazılımın belli bir kültüre uyarlanması (Localization).");
                break;
            case "yetenek":
                Console.WriteLine("Yetenek: Bir işi başarma potansiyeli (Talent).");
                break;
            case "yeterlilik":
                Console.WriteLine("Yeterlilik: Bir işi yapmak için gereken asgari şart (Competence).");
                break;
            case "yetki":
                Console.WriteLine("Yetki: Bir işi yapabilme yasal hakkı (Authority).");
                break;
            case "yığın":
                Console.WriteLine("Yığın: Düzenli olmayan topluluk; veri yapılarında 'Stack'.");
                break;
            case "yıkım":
                Console.WriteLine("Yıkım: Tahribat; büyük ölçekli zarar.");
                break;
            case "yıllık":
                Console.WriteLine("Yıllık: Bir yıl süreli; senelik.");
                break;
            case "yıldız":
                Console.WriteLine("Yıldız: Işık saçan gök cismi; mecazen başarılı kişi.");
                break;
            case "yoğunluk":
                Console.WriteLine("Yoğunluk: Birim hacimdeki madde miktarı; iş yükü.");
                break;
            case "yol":
                Console.WriteLine("Yol: Güzergah; mecazen yöntem.");
                break;
            case "yolsuzluk":
                Console.WriteLine("Yolsuzluk: Yetkinin haksız çıkar için kullanılması.");
                break;
            case "yorum":
                Console.WriteLine("Yorum: Bir metni veya durumu açıklama; kod içindeki notlar.");
                break;
            case "yöndem":
                Console.WriteLine("Yöndem: Metot, sistem.");
                break;
            case "yönerge":
                Console.WriteLine("Yönerge: Bir işin nasıl yapılacağını gösteren kılavuz.");
                break;
            case "yönetim":
                Console.WriteLine("Yönetim: Belirlenmiş hedeflere ulaşma süreci (Management).");
                break;
            case "yönetişim":
                Console.WriteLine("Yönetişim: Karar alma süreçlerine katılım ve etkileşim (Governance).");
                break;
            case "yöntem":
                Console.WriteLine("Yöntem: Bir amaca ulaşmak için izlenen yol (Method).");
                break;
            case "yönlendirme":
                Console.WriteLine("Yönlendirme: Bir şeyi hedefe sevk etme (Routing).");
                break;
            case "yükümlülük":
                Console.WriteLine("Yükümlülük: Yapılması zorunlu olan görev, ödev.");
                break;
        }
        break;

    case 'z':
    case 'Z':
        Console.WriteLine("Kelime seçiniz. ( Zaaf, Zafiyet, Zafer, Zahiri, Zahmet, Zait, Zaman, Zamanlama, Zam, Zaman aşımı, Zanaat, Zapt, Zarar, Zarf, Zaruri, Zati, Zayiat, Zayi, Zabit, Zeval, Zekâ, Zemin, Zenginlik, Zerre, Zevk, Zımni, Zıtlık, Zırh, Zihin, Zikir, Zilyet, Zimmet, Zinde, Zincir, Zirve, Ziyan, Ziyaret, Zoralım, Zorba, Zorluk, Zorunluluk, Zuhur, Zulüm, Zümre, Züccaciye, Zül, Zümrüt, Zihinsel, Ziynet, Zeminlik ): ");
        kelimeler = Console.ReadLine().ToLower();


        switch (kelimeler)
        {
            case "zaaf":
                Console.WriteLine("Zaaf: İrade zayıflığı, bir şeye karşı koyamama durumu.");
                break;
            case "zafiyet":
                Console.WriteLine("Zafiyet: Arık bir durum; yazılımda güvenlik açığı (Vulnerability).");
                break;
            case "zafer":
                Console.WriteLine("Zafer: Bir mücadele veya yarış sonunda kazanılan başarı.");
                break;
            case "zahiri":
                Console.WriteLine("Zahiri: Görünüşteki, gerçek olmayan, sanal.");
                break;
            case "zahmet":
                Console.WriteLine("Zahmet: Bir işi yaparken çekilen güçlük ve yorgunluk.");
                break;
            case "zait":
                Console.WriteLine("Zait: Gereksiz, fazla olan; toplama işareti.");
                break;
            case "zaman":
                Console.WriteLine("Zaman: Olayların geçmişten geleceğe akıp gittiği süre.");
                break;
            case "zamanlama":
                Console.WriteLine("Zamanlama: Bir işin en uygun vakitte yapılması (Timing).");
                break;
            case "zam":
                Console.WriteLine("Zam: Bir fiyatın veya ücretin artırılması.");
                break;
            case "zaman aşımı":
                Console.WriteLine("Zaman Aşımı: Bir hakkın veya işlemin süresinin dolması (Timeout).");
                break;
            case "zanaat":
                Console.WriteLine("Zanaat: El becerisi ve deneyim gerektiren meslek.");
                break;
            case "zapt":
                Console.WriteLine("Zapt: Ele geçirme; kayıt altına alma.");
                break;
            case "zarar":
                Console.WriteLine("Zarar: Bir işin sonucunda ortaya çıkan kayıp.");
                break;
            case "zarf":
                Console.WriteLine("Zarf: Kağıt kap; dil bilgisinde belirteç; yazılımda veri taşıyıcı.");
                break;
            case "zaruri":
                Console.WriteLine("Zaruri: Zorunlu olan, yapılması gereken.");
                break;
            case "zati":
                Console.WriteLine("Zati: Kendine has, şahsi.");
                break;
            case "zayiat":
                Console.WriteLine("Zayiat: İşletmede veya savaşta verilen kayıp, eksilme.");
                break;
            case "zayi":
                Console.WriteLine("Zayi: Kaybolmuş, elden çıkmış olan.");
                break;
            case "zabit":
                Console.WriteLine("Zabit: Tutanak; rütbeli asker.");
                break;
            case "zeval":
                Console.WriteLine("Zeval: Yok olma, sona erme; suç, kabahat.");
                break;
            case "zekâ":
                Console.WriteLine("Zekâ: Kavrama, öğrenme ve çözüm üretme yeteneği.");
                break;
            case "zemin":
                Console.WriteLine("Zemin: Yer, taban; mecazen bir işin dayandığı temel şartlar.");
                break;
            case "zenginlik":
                Console.WriteLine("Zenginlik: Kaynakların bolluğu; veri çeşitliliği.");
                break;
            case "zerre":
                Console.WriteLine("Zerre: Çok küçük parça, atom.");
                break;
            case "zevk":
                Console.WriteLine("Zevk: Beğeni, alınan keyif.");
                break;
            case "zımni":
                Console.WriteLine("Zımni: Kapalı, dolaylı yoldan anlatılan (Implicit).");
                break;
            case "zıtlık":
                Console.WriteLine("Zıtlık: İki durumun birbirine tamamen karşıt olması (Contrast).");
                break;
            case "zırh":
                Console.WriteLine("Zırh: Koruyucu kaplama; güvenlik kalkanı.");
                break;
            case "zihin":
                Console.WriteLine("Zihin: Bilinç, düşünme ve anlama merkezi.");
                break;
            case "zikir":
                Console.WriteLine("Zikir: Anma, sürekli tekrarlama.");
                break;
            case "zilyet":
                Console.WriteLine("Zilyet: Bir malı fiilen elinde bulunduran kişi.");
                break;
            case "zimmet":
                Console.WriteLine("Zimmet: Birine emanet edilen kurum malı; birinin üzerine kayıtlı borç.");
                break;
            case "zinde":
                Console.WriteLine("Zinde: Canlı, hareketli, dinç.");
                break;
            case "zincir":
                Console.WriteLine("Zincir: Birbirine bağlı halkalar; süreçler dizisi (Chain).");
                break;
            case "zirve":
                Console.WriteLine("Zirve: En üst nokta, doruk.");
                break;
            case "ziyan":
                Console.WriteLine("Ziyan: Boşa giden emek veya masraf.");
                break;
            case "ziyaret":
                Console.WriteLine("Ziyaret: Birini görmeye gitme; web sayfasına giriş yapılması.");
                break;
            case "zoralım":
                Console.WriteLine("Zoralım: Müsadere; devletin bir mala el koyması.");
                break;
            case "zorba":
                Console.WriteLine("Zorba: Gücüne güvenerek başkalarına baskı yapan.");
                break;
            case "zorluk":
                Console.WriteLine("Zorluk: Bir işin yapılmasını engelleyen durum.");
                break;
            case "zorunluluk":
                Console.WriteLine("Zorunluluk: Yapılması gereken, kaçınılmaz olan.");
                break;
            case "zuhur":
                Console.WriteLine("Zuhur: Ortaya çıkma, görünme.");
                break;
            case "zulüm":
                Console.WriteLine("Zulüm: Haksızlık, eziyet.");
                break;
            case "zümre":
                Console.WriteLine("Zümre: Benzer özellik taşıyan topluluk, sınıf.");
                break;
            case "züccaciye":
                Console.WriteLine("Züccaciye: Cam, porselen gibi mutfak eşyaları satılan yer.");
                break;
            case "zül":
                Console.WriteLine("Zül: Alçalma, küçülme.");
                break;
            case "zümrüt":
                Console.WriteLine("Zümrüt: Yeşil renkli değerli bir taş.");
                break;
            case "zihinsel":
                Console.WriteLine("Zihinsel: Akıl ve düşünce ile ilgili olan.");
                break;
            case "ziynet":
                Console.WriteLine("Ziynet: Süs, takı.");
                break;
            case "zeminlik":
                Console.WriteLine("Zeminlik: Bir yerin tabanına ait olma durumu.");
                break;
        }
        break;

    default:
        sozluk = "mdjfjjfjff";
            break;


}























