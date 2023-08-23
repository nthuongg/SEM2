<?php $__env->startSection('content'); ?>

<?php if($message = Session::get('success')): ?>

<div class="alert alert-success">
	<?php echo e($message); ?>

</div>

<?php endif; ?>

<div class="card">
	<div class="card-header">
		<div class="row">
			<div class="col col-md-6"><b>Book Data</b></div>
			<div class="col col-md-6">
            <form action="<?php echo e(route('books.search')); ?>" method="GET">
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
			<?php if(count($data) > 0): ?>

				<?php $__currentLoopData = $data; $__env->addLoop($__currentLoopData); foreach($__currentLoopData as $row): $__env->incrementLoopIndices(); $loop = $__env->getLastLoop(); ?>

					<tr>
                        <td><?php echo e($row->authorid); ?></td>
						<td><?php echo e($row->title); ?></td>
						<td><?php echo e($row->ISBN); ?></td>
                        <td><?php echo e($row->pub_year); ?></td>
                        <td><?php echo e($row->available == 1 ? 'yes' : 'no'); ?></td>
					</tr>


				<?php endforeach; $__env->popLoop(); $loop = $__env->getLastLoop(); ?>

			<?php else: ?>
				<tr>
					<td colspan="5" class="text-center">No Data Found</td>
				</tr>
			<?php endif; ?>
		</table>
		<?php echo $data->links(); ?>

	</div>
</div>

<?php $__env->stopSection(); ?>

<?php echo $__env->make('master', \Illuminate\Support\Arr::except(get_defined_vars(), ['__data', '__path']))->render(); ?><?php /**PATH D:\SEM2\PHP\Exam\bookInformation\resources\views/index.blade.php ENDPATH**/ ?>