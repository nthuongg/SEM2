@extends('master')

@section('content')

@if($message = Session::get('success'))

<div class="alert alert-success">
	{{ $message }}
</div>

@endif

<div class="card">
	<div class="card-header">
		<div class="row">
			<div class="col col-md-6"><b>Book Data</b></div>
			<div class="col col-md-6">
            <form action="{{ route('books.search') }}" method="GET">
                <input type="text" name="query" placeholder=" Search book by Name ...">
                <button type="submit">Search</button>
            </form>
			</div>
		</div>
	</div>
	<div class="card-body">
		<table class="table table-bordered">
			<tr>
                <th>Authorid</th>
				<th>Title</th>
				<th>ISBN</th>
				<th>Pub_year</th>
				<th>Available</th>
			</tr>
			@if(count($data) > 0)

				@foreach($data as $row)

					<tr>
                        <td>{{ $row->authorid }}</td>
						<td>{{ $row->title }}</td>
						<td>{{ $row->ISBN }}</td>
                        <td>{{ $row->pub_year }}</td>
                        <td>{{ $row->available == 1 ? 'yes' : 'no' }}</td>
					</tr>


				@endforeach

			@else
				<tr>
					<td colspan="5" class="text-center">No Data Found</td>
				</tr>
			@endif
		</table>
		{!! $data->links() !!}
	</div>
</div>

@endsection
