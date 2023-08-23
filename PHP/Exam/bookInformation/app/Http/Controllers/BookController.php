<?php

namespace App\Http\Controllers;

use App\Models\Book;
use Illuminate\Http\Request;

class BookController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $data = Book::latest()->paginate(10);

        return view('index', compact('data'));
    }



    public function searchBooks(Request $request)
    {
        $query = $request->input('query'); // Lấy từ khóa tìm kiếm từ request

        $books = Book::where('title', 'like', "%$query%")->get(); // Tìm kiếm sách theo tên

        return view('books', compact('books', 'query'));
    }

}
